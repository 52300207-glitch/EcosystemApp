using ClosedXML;
using EcosystemApp.BUS;
using EcosystemApp.DTO;
using EcosystemApp.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EcosystemApp.GUI.ChildPackageForm
{
    public partial class AddPackageForm : Form
    {
        private SearchHelper SearchHelper = new SearchHelper();
        private List<PackagingTypeDTO> AllPackagingTypes = new PackagingTypeBUS().GetAllPackagingType();
        private List<PackageDTO> NewPackages = new List<PackageDTO>();
        private PackageBUS PackageBUS = new PackageBUS();
        public AddPackageForm()
        {
            InitializeComponent();
            InitializeDefaultValues();
        }

        private void InitializeDefaultValues()
        {
            SetupDgvPackagesListDetail();

        }

        private void SetupDgvPackagesListDetail()
        {
            DgvPackagesListDetail.ReadOnly = true;
            DgvPackagesListDetail.AllowUserToAddRows = false;
            DgvPackagesListDetail.AllowUserToDeleteRows = false;
            DgvPackagesListDetail.AllowUserToOrderColumns = false;
            DgvPackagesListDetail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            DgvPackagesListDetail.MultiSelect = false;
            DgvPackagesListDetail.RowTemplate.Height = 30;

            DgvPackagesListDetail.Columns.Clear();

            // --- STT ---
            DataGridViewTextBoxColumn colIndex = new DataGridViewTextBoxColumn();
            colIndex.HeaderText = "STT";
            colIndex.Name = "STT";
            colIndex.Width = 50;
            colIndex.SortMode = DataGridViewColumnSortMode.NotSortable;

            // --- Tên bao bì ---
            DataGridViewTextBoxColumn colPackageName = new DataGridViewTextBoxColumn();
            colPackageName.HeaderText = "Tên bao bì";
            colPackageName.Name = "PackageName";
            colPackageName.SortMode = DataGridViewColumnSortMode.NotSortable;

            // --- Chất liệu ---
            DataGridViewTextBoxColumn colMaterial = new DataGridViewTextBoxColumn();
            colMaterial.HeaderText = "Chất liệu";
            colMaterial.Name = "Material";
            colMaterial.SortMode = DataGridViewColumnSortMode.NotSortable;

            // --- Giá bán ---
            DataGridViewTextBoxColumn colPrice = new DataGridViewTextBoxColumn();
            colPrice.HeaderText = "Giá bán";
            colPrice.Name = "Price";
            colPrice.SortMode = DataGridViewColumnSortMode.NotSortable;

            // --- Mã Serial ---
            DataGridViewTextBoxColumn colSerial = new DataGridViewTextBoxColumn();
            colSerial.HeaderText = "Mã Serial";
            colSerial.Name = "Serial";
            colSerial.SortMode = DataGridViewColumnSortMode.NotSortable;

            // --- Số lần tái sử dụng ---
            DataGridViewTextBoxColumn colReuseCount = new DataGridViewTextBoxColumn();
            colReuseCount.HeaderText = "Giới hạng tái sử dụng";
            colReuseCount.Name = "ReuseCount";
            colReuseCount.SortMode = DataGridViewColumnSortMode.NotSortable;

            DgvPackagesListDetail.Columns.AddRange(colIndex, colPackageName, colMaterial, colPrice, colSerial, colReuseCount);

            // Tự động đánh số STT
            DgvPackagesListDetail.RowPostPaint += (s, e) =>
            {
                DgvPackagesListDetail.Rows[e.RowIndex].Cells["STT"].Value = (e.RowIndex + 1).ToString();
            };
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
        }

        private void ShowPackagingSuggestions(string keyword, List<PackagingTypeDTO> source, ListBox listBox)
        {
            listBox.Items.Clear();
            if (string.IsNullOrWhiteSpace(keyword) || source == null || source.Any(p => p.GetTypeName() == keyword))
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

        private void BtnRefeshClick(object sender, EventArgs e)
        {
            TbPackageTypeName.Text = "";
            TbMaterial.Text = "";
            TbSellingPrice.Text = "";
            TbSerialCode.Text = "";
            TbReuseLimit.Text = "";
            TbPackageTypeName.Focus();

        }

        private void BtnAddClick(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(TbPackageTypeName.Text) || string.IsNullOrEmpty(TbMaterial.Text) ||
                string.IsNullOrEmpty(TbReuseLimit.Text) || string.IsNullOrEmpty(TbSellingPrice.Text) ||
                string.IsNullOrEmpty(TbSerialCode.Text))
            {
                RJMessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }else
            {

                try
                {
                    int.Parse((TbReuseLimit.Text));
                    int.Parse(TbSellingPrice.Text);

                }
                catch (Exception)
                {
                    RJMessageBox.Show("Giá tiền và gới hạn tái sử dụng phải là số !", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                try
                {
                    NewPackages = PackageBUS.CreateNew(NewPackages, TbPackageTypeName.Text, TbMaterial.Text, TbReuseLimit.Text, TbSellingPrice.Text, TbSerialCode.Text);
                    TbPackageTypeName.Text = "";
                    TbMaterial.Text = "";
                    TbSellingPrice.Text = "";
                    TbSerialCode.Text = "";
                    TbReuseLimit.Text = "";
                    TbPackageTypeName.Focus();

                    RefeshDgvPackagesListDetail();
                }catch(Exception ex)
                {
                    RJMessageBox.Show(ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

            }
        }

        private void RefeshDgvPackagesListDetail()
        {
            // Xóa dữ liệu cũ
            DgvPackagesListDetail.Rows.Clear();

            if (NewPackages == null && NewPackages.Count == 0)
                return;

            // Thêm dòng mới vào bảng
            foreach (var item in NewPackages)
            {
                DgvPackagesListDetail.Rows.Add(
                    null,                // STT = null → RowPostPaint sẽ tự đánh số
                    item.GetPackagingType().GetTypeName(),   // Tên bao bì
                    item.GetPackagingType().GetMaterial(),      // Chất liệu
                    item.GetPackagingType().GetDeposit(),  // Giá bán
                    item.GetSerialCode(),    // Mã Serial
                    item.GetPackagingType().GetReuseLimit()     // Giới hạn tái sử dụng
                );
            }
        }

        private PackageDTO GetSelectedItem()
        {
            if (DgvPackagesListDetail.SelectedRows.Count == 0)
                return null;

            int index = DgvPackagesListDetail.SelectedRows[0].Index;

            if (index < 0 && index >= NewPackages.Count)
                return null;

            return NewPackages[index];
        }

        private void BtnDeleteClick(object sender, EventArgs e)
        {
            var selectedItem = GetSelectedItem();

            if (selectedItem == null)
            {
                RJMessageBox.Show("Vui lòng chọn 1 dòng để xóa!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var confirm = RJMessageBox.Show(
                "Bạn có chắc muốn xóa mục này?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                // Xóa khỏi list
                NewPackages.Remove(selectedItem);

                // Refresh lại DataGridView
                RefeshDgvPackagesListDetail();

            }
        }

        private void BtnCloseClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSaveClick(object sender, EventArgs e)
        {
            PackageBUS.SaveNewPackages(NewPackages);

            TbPackageTypeName.Text = "";
            TbMaterial.Text = "";
            TbSellingPrice.Text = "";
            TbSerialCode.Text = "";
            TbReuseLimit.Text = "";
            DgvPackagesListDetail.Rows.Clear();
        }

        private void TbPackageTypeNameLeave(object sender, EventArgs e)
        {
            if (!LbSuggestions.Focused)
                LbSuggestions.Visible = false;
        }
    }
}
