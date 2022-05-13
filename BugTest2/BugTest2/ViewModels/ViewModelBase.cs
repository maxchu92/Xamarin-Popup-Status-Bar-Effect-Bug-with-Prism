﻿using Prism.AppModel;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;
using System;
using System.Collections.Generic;
using System.Text;

namespace BugTest2.ViewModels {
	public class ViewModelBase : BindableBase, IInitialize, INavigationAware, IDestructible, IPageLifecycleAware {
		protected INavigationService NavigationService { get; private set; }

		private string _title;
		public string Title {
			get { return _title; }
			set { SetProperty(ref _title, value); }
		}

		public ViewModelBase(INavigationService navigationService) {
			NavigationService = navigationService;
		}

		public virtual void Initialize(INavigationParameters parameters) {

		}

		public virtual void OnNavigatedFrom(INavigationParameters parameters) {

		}

		public virtual void OnNavigatedTo(INavigationParameters parameters) {

		}

		public virtual void Destroy() {

		}
		public void OnAppearing() {
			Console.WriteLine($"{Title} appearing");
		}

		public void OnDisappearing() {
			Console.WriteLine($"{Title} disappearing");
		}
	}
}
