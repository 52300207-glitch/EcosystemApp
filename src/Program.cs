using DocumentFormat.OpenXml.Bibliography;
using EcosystemApp.DAL;
using EcosystemApp.DTO;
using EcosystemApp.GUI;
using EcosystemApp.GUI.ChildReportForm;
using System.Collections.Generic;

namespace EcosystemApp
{
    internal static class Program
    {
        public static UserDTO CurrentUser;
        public static AdminDTO CurrentAdmin;

        [STAThread]
        
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //Application.Run(new Main());
            //Application.Run(new HomePageForm(new Main(new EcosystemApp.DAL.EmployeeDAL().GetById("EMP01"))));
            //Application.Run(new HomePageForm(new Main()));
            //Application.Run(new TestForm());

            //Bước 1: Mở form đăng nhập trước
            //FormLogin loginForm = new FormLogin();

            //Application.Run(new FormLogin());

            //DataCreating data = new DataCreating();
            //data.CreateSampleData();


            //Cái này là cái chính thức khi chạy thiệt
            // Kiểm tra email lần đầu
            // if (string.IsNullOrEmpty(EcosystemApp.src.Settings.Default.UserEmail))
            //{
            //    using (var emailForm = new EmailUpdatingForm())
            //    {
            //        if (emailForm.ShowDialog() != DialogResult.OK)
            //        {
            //            // Nếu user hủy → thoát app
            //            return;
            //        }
            //    }
            //}

            //// Mở form chính
            Application.Run(new FormLogin());

        }
    }
}
