using EcosystemApp.BUS;
using EcosystemApp.DTO;
using EcosystemApp.Utils;
using System.Data;

namespace EcosystemApp.GUI.ChildPackageForm
{
    public partial class EditPackageForm : Form
    {
        private PackageDTO OldPackage;
        private PackageDTO ChangedPackage;
        private SearchHelper SearchHelper = new SearchHelper();
        private List<PackagingTypeDTO> AllPackagingTypes = new PackagingTypeBUS().GetAllPackagingType();
        private PackageBUS PackageBUS = new PackageBUS();

        public EditPackageForm(PackageDTO package)
        {
            InitializeComponent();
            OldPackage = package;
            InitializeDefaultVaules();
            ChangedPackage = PackageBUS.Copy(package);
        }

        private void InitializeDefaultVaules()
        {
            TbPackageTypeName.Text = OldPackage.GetPackagingType().GetTypeName();
            TbReuseLimit.Text = OldPackage.GetPackagingType().GetReuseLimit().ToString();
            TbSellingPrice.Text = OldPackage.GetPackagingType().GetDeposit().ToString();
            TbSerialCode.Text = OldPackage.GetSerialCode();
            TbMaterial.Text = OldPackage.GetPackagingType().GetMaterial();
            BtnClose.Enabled = false;
            BtnChangeAll.Enabled = true;
            BtnSave.Enabled = true;
        }

        private void BtnCloseClick(object sender, EventArgs e)
        {
            BtnClose.Enabled = false;
            BtnChangeAll.Enabled = true;
            BtnSave.Enabled = true;

            var packagingType = AllPackagingTypes.Where(p => p.GetTypeName() == TbPackageTypeName.Text).ToList();
            if (packagingType.Any())
            {
                TbSellingPrice.Text = packagingType[0].GetDeposit().ToString();
                TbMaterial.Text = packagingType[0].GetMaterial();
                TbReuseLimit.Text = packagingType[0].GetReuseLimit().ToString();

                TbSellingPrice.Enabled = false;
                TbMaterial.Enabled = false;
                TbReuseLimit.Enabled = false;
            }
            else
            {
                TbSellingPrice.Text = "";
                TbMaterial.Text = "";
                TbReuseLimit.Text = "";

                TbSellingPrice.Enabled = true;
                TbMaterial.Enabled = true;
                TbReuseLimit.Enabled = true;
            }

            if (!BtnChangeAll.Enabled)
            {
                TbSellingPrice.Enabled = true;
                TbMaterial.Enabled = true;
                TbReuseLimit.Enabled = true;
            }
        }

        private void TbPackageTypeNameTextChanged(object sender, EventArgs e)
        {
            ShowPackagingSuggestions(TbPackageTypeName.Text, AllPackagingTypes, LbSuggestions);
            var packagingType = AllPackagingTypes.Where(p => p.GetTypeName() == TbPackageTypeName.Text).ToList();
            if (packagingType.Any())
            {
                TbSellingPrice.Text = packagingType[0].GetDeposit().ToString();
                TbMaterial.Text = packagingType[0].GetMaterial();
                TbReuseLimit.Text = packagingType[0].GetReuseLimit().ToString();

                TbSellingPrice.Enabled = false;
                TbMaterial.Enabled = false;
                TbReuseLimit.Enabled = false;
                LbSuggestions.Visible = false;
            }
            else
            {
                TbSellingPrice.Text = "";
                TbMaterial.Text = "";
                TbReuseLimit.Text = "";

                TbSellingPrice.Enabled = true;
                TbMaterial.Enabled = true;
                TbReuseLimit.Enabled = true;
            }

            if (!BtnChangeAll.Enabled)
            {
                TbSellingPrice.Enabled = true;
                TbMaterial.Enabled = true;
                TbReuseLimit.Enabled = true;
            }
        }

        private void ShowPackagingSuggestions(string keyword, List<PackagingTypeDTO> source, ListBox listBox)
        {
            listBox.Items.Clear();
            if (string.IsNullOrWhiteSpace(keyword) || source == null || source.Any(p => p.GetTypeName().Trim() == keyword.Trim()))
            {
                listBox.Visible = false;
                return;
            }

            var filtered = SearchHelper.SearchPackagingTypeByKeyword(source, keyword);

            if (filtered.Any())
            {
                foreach (var item in filtered)
                {
                    listBox.Items.Add(item.GetTypeName());
                }

                listBox.Height = Math.Min(filtered.Count * 24, 120);
                listBox.Visible = true;
                listBox.BringToFront();
            }
            else
            {
                listBox.Visible = false;
            }
        }

        private void ListBoxClick(ListBox listBox, TextBox target)
        {
            if (listBox.SelectedItem != null)
            {
                target.Text = listBox.SelectedItem.ToString();
                target.SelectionStart = target.Text.Length;
                listBox.Visible = false;
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                if (LbSuggestions.Visible && LbSuggestions.SelectedItem != null)
                    ListBoxClick(LbSuggestions, TbPackageTypeName);
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void LbSuggestionsClick(object sender, EventArgs e)
        {
            ListBoxClick(LbSuggestions, TbPackageTypeName);
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            string packageType = TbPackageTypeName.Text;
            string material = TbMaterial.Text;
            string reuseLimit = TbReuseLimit.Text;
            string sellingPrice = TbSellingPrice.Text;
            string serialCode = TbSerialCode.Text;
            // set change package
            if (string.IsNullOrEmpty(packageType) || string.IsNullOrEmpty(material) ||
            string.IsNullOrEmpty(reuseLimit) || string.IsNullOrEmpty(sellingPrice) ||
            string.IsNullOrEmpty(serialCode))
            {
                RJMessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {

                try
                {

                    ChangedPackage.SetSerialCode(serialCode);
                    ChangedPackage.GetPackagingType().SetDeposit(int.Parse(sellingPrice));
                    ChangedPackage.GetPackagingType().SetReuseLimit(int.Parse(reuseLimit));
                    ChangedPackage.GetPackagingType().SetMaterial(material);
                    ChangedPackage.GetPackagingType().SetTypeName(packageType);
                    if(!PackageBUS.isExist(ChangedPackage.GetSerialCode()) || serialCode == OldPackage.GetSerialCode())
                    {
                        if (BtnChangeAll.Enabled)
                        {
                            var result = RJMessageBox.Show("Bạn có muốn thay đổi bao bì này không!", "Thông tin",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {

                                PackageBUS.UpdatePackage(OldPackage, ChangedPackage);
                                Close();
                            }
                            else
                            {
                                return;
                            }
                        }
                        else
                        {
                            var result = RJMessageBox.Show("Bạn có muốn thay đổi tất cả bao bì có cùng tên và thông tin của bao bì đó không", "Thông tin",
                                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                            if (result == DialogResult.Yes)
                            {
                                PackageBUS.UpdatePackagesSameType(OldPackage, ChangedPackage);
                                Close();
                            }
                            else
                            {
                                return;
                            }
                        }
                    }else
                    {
                        RJMessageBox.Show("Mã serial bao bì đã có sẳn", "Lỗi",
                                MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (Exception)
                {
                    RJMessageBox.Show("Giá tiền và gới hạn tái sử dụng phải là số !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }

        }

        private void TbPackageTypeNameLeave(object sender, EventArgs e)
        {
            if (!LbSuggestions.Focused)
                LbSuggestions.Visible = false;
        }

        private void BtnChangeAllClick(object sender, EventArgs e)
        {
            BtnClose.Enabled = true;
            BtnChangeAll.Enabled = false;
            BtnSave.Enabled = true;
            if (!BtnChangeAll.Enabled)
            {
                TbSellingPrice.Enabled = true;
                TbMaterial.Enabled = true;
                TbReuseLimit.Enabled = true;
            }
        }
    }
}
