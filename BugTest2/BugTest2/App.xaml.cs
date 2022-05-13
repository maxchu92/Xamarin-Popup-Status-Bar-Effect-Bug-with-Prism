using BugTest2.ViewModels;
using BugTest2.Views;
using Prism;
using Prism.Ioc;
using Prism.Plugin.Popups;
using Xamarin.Essentials.Implementation;
using Xamarin.Essentials.Interfaces;
using Xamarin.Forms;

namespace BugTest2 {
	public partial class App {
		public App(IPlatformInitializer initializer)
			: base(initializer) {
		}

		protected override async void OnInitialized() {
			InitializeComponent();

			await NavigationService.NavigateAsync("NavigationPage/MainPage");
		}

		protected override void RegisterTypes(IContainerRegistry containerRegistry) {
			containerRegistry.RegisterSingleton<IAppInfo, AppInfoImplementation>();
			containerRegistry.RegisterPopupNavigationService();
			containerRegistry.RegisterPopupDialogService();

			containerRegistry.RegisterForNavigation<NavigationPage>();
			containerRegistry.RegisterForNavigation<MainPage, MainPageViewModel>();
			containerRegistry.RegisterForNavigation<ContentTestPage, ContentTestPageViewModel>();
			containerRegistry.RegisterForNavigation<PopupTestPage, PopupTestPageViewModel>();
		}
		protected override void OnResume() {
			this.PopupPluginOnResume();
		}

		protected override void OnSleep() {
			this.PopupPluginOnSleep();
		}
	}
}
