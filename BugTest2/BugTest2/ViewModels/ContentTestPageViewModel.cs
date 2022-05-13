using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BugTest2.ViewModels {
	public class ContentTestPageViewModel : ViewModelBase {

		private DelegateCommand _backToRootCommand;
		public DelegateCommand BackToRootCommand => _backToRootCommand ?? (_backToRootCommand = new DelegateCommand(ExecuteBackToRootCommand, CanExecuteBackToRootCommand));

		protected async void ExecuteBackToRootCommand() {
			try {
				await NavigationService.GoBackToRootAsync();
			} catch (Exception ex) {
				System.Diagnostics.Debug.WriteLine(ex);
			}
		}


		bool CanExecuteBackToRootCommand() {
			return true;
		}

		public ContentTestPageViewModel(INavigationService navigationService) : base(navigationService) {
			Title = "ContentTestPageViewModel";

		}
	}
}
