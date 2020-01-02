using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Exchange.Model.Data;
using Exchange.Model.Repository;
using Exchange.Model.Service;
using Exchange.Presenter;
using Exchange.View;
using Ninject;

namespace Exchange
{
    static class Program
    {
        static Ninject.StandardKernel kernel = new StandardKernel();

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            kernel.Bind<ICashierView>().ToConstant(new CashierView()).InSingletonScope();
            kernel.Bind<IAdminView>().ToConstant(new AdminView()).InSingletonScope();
            kernel.Bind<IRepository<Transaction>>().ToConstant(new Repository<Transaction>()).InSingletonScope();
            kernel.Bind<IRepository<Currency>>().ToConstant(new Repository<Currency>()).InSingletonScope();
            kernel.Bind<ICurrencyService>().ToConstant(new CurrencyService(kernel.Get<IRepository<Currency>>()))
                .InSingletonScope();
            kernel.Bind<ITransactionService>()
                .ToConstant(new TransactionService(kernel.Get<IRepository<Transaction>>())).InSingletonScope();
            kernel.Bind<ICashierPresenter>().ToConstant(new CashierPresenter(kernel.Get<ICashierView>(),
                kernel.Get<ICurrencyService>(), kernel.Get<ITransactionService>())).InSingletonScope();
            kernel.Bind<IAdminPresenter>().ToConstant(new AdminPresenter(kernel.Get<IAdminView>(),
                kernel.Get<ICurrencyService>(), kernel.Get<ITransactionService>())).InSingletonScope();
            Application.Run(new FormManager());
        }

        class FormManager : ApplicationContext
        {
            private void onFormClosed(object sender, EventArgs e)
            {
                if (Application.OpenForms.Count == 0)
                {
                    ExitThread();
                }
            }

            public FormManager()
            {
                var f1 = (Form) kernel.Get<ICashierView>();
                f1.FormClosed += onFormClosed;
                f1.Show();
                var f2 = (Form) kernel.Get<IAdminView>();
                f2.FormClosed += onFormClosed;
                f2.Show();
            }
        }
    }
}