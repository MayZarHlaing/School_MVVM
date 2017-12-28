using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using School_MVVM.Common.DataModel;
using School_MVVM.Common.ViewModel;
using School_MVVM.MyDbContextDataModel;
using School_MVVM.DataBase;
using School_MVVM.DataModel;
using School_MVVM.ViewModels.Login;

namespace School_MVVM.ViewModels
{
    /// <summary>
    /// Represents the root POCO view model for the MyDbContext data model.
    /// </summary>
    public partial class MyDbContextViewModel : DocumentsViewModel<MyDbContextModuleDescription, IMyDbContextUnitOfWork>
    {
        LoginViewModel loginViewModel;
        const string TablesGroup = "Tables";

        const string ViewsGroup = "Views";

        /// <summary>
        /// Creates a new instance of MyDbContextViewModel as a POCO view model.
        /// </summary>
        public static MyDbContextViewModel Create()
        {
            return ViewModelSource.Create(() => new MyDbContextViewModel());
        }

        /// <summary>
        /// Initializes a new instance of the MyDbContextViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the MyDbContextViewModel type without the POCO proxy factory.
        /// </summary>
        protected MyDbContextViewModel()
            : base(UnitOfWorkSource.GetUnitOfWorkFactory())
        {
            loginViewModel = LoginViewModel.Create();
            loginViewModel.SetParentViewModel(this);
        }
        protected IDialogService DialogService
        {
            get { return this.GetService<IDialogService>(); }
        }
        protected IMessageBoxService MessageService
        {
            get { return this.GetService<IMessageBoxService>(); }
        }
        public override void OnLoaded(MyDbContextModuleDescription module)
        {
            base.OnLoaded(module);
            Login();
        }

      public void Login()
        {
            OnLogin(DialogService.ShowDialog(MessageButton.OKCancel, "Please enter you credentials", "LoginView", loginViewModel));
        }

      private void OnLogin(MessageResult result)
      {
          if (result == MessageResult.Cancel)
              State = AppState.ExitQueued;
          else
          {
              if (loginViewModel.IsCurrentUserCredentialsValid)
                  State = AppState.Autorized;
              else
                  Login();
          }
         
      }
      public virtual AppState State { get; set; }
        protected override MyDbContextModuleDescription[] CreateModules()
        {
            return new MyDbContextModuleDescription[] {
                
                new MyDbContextModuleDescription("Students", "StudentCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Students)),
                new MyDbContextModuleDescription("Standards", "StandardCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Standards)),
                new MyDbContextModuleDescription("Course", "CourseCollectionView", TablesGroup, GetPeekCollectionViewModelFactory(x => x.Course)),
			};
        }

        protected void OnStateChanged()
        {
            this.RaiseCanExecuteChanged(x => x.LogOut());
            if (State == AppState.Autorized)
                Messenger.Default.Send<string>(loginViewModel.CurrentUser.Login);
            else
                Messenger.Default.Send<string>(string.Empty);
        }


       public void LogOut()
        {
            //State = AppState.ExitQueued;
            //System.Diagnostics.Process.Start(System.Windows.Forms.Application.ExecutablePath);
            State = AppState.ExitQueued;
            System.Diagnostics.Process.Start(System.Windows.Forms.Application.ExecutablePath);
        }
    }

    public partial class MyDbContextModuleDescription : ModuleDescription<MyDbContextModuleDescription>
    {
        public MyDbContextModuleDescription(string title, string documentType, string group, Func<MyDbContextModuleDescription, object> peekCollectionViewModelFactory = null)
            : base(title, documentType, group, peekCollectionViewModelFactory)
        {
        }
    }
    public enum AppState
    {
        NotAutorized,
        Autorized,
        ExitQueued,
        Authorized
    }
}