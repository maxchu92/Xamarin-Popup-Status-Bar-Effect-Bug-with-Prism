using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using Rg.Plugins.Popup.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BugTest2.ViewModels {
	public class PopupTestPageViewModel : ViewModelBase {

		private DelegateCommand _backToRootCommand;
		private readonly IPopupNavigation _popupNavigation;

		public DelegateCommand BackToRootCommand => _backToRootCommand ?? (_backToRootCommand = new DelegateCommand(ExecuteBackToRootCommand, CanExecuteBackToRootCommand));

		protected async void ExecuteBackToRootCommand() {
			try {
#if (false)
				await _popupNavigation.PopAllAsync();
				await NavigationService.GoBackToRootAsync();
#else
				await NavigationService.NavigateAsync("/NavigationPage/MainPage");
#endif
			} catch (Exception ex) {
				System.Diagnostics.Debug.WriteLine(ex);
			}
		}

		bool CanExecuteBackToRootCommand() {
			return true;
		}

		public PopupTestPageViewModel(INavigationService navigationService, IPopupNavigation popupNavigation) : base(navigationService) {
			_popupNavigation = popupNavigation;

			Title = "PopupPageViewModel";

		}
	}
}
