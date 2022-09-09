﻿using System;
using System.Threading.Tasks;
using Unigram.Navigation;
using Unigram.Navigation.Services;
using Unigram.Services;
using Windows.UI.Xaml.Navigation;

namespace Unigram.ViewModels
{
    public class TLViewModelBase : ViewModelBase, INavigable
    {
        private readonly IClientService _clientService;
        private readonly ISettingsService _settingsService;
        private readonly IEventAggregator _aggregator;

        public TLViewModelBase(IClientService clientService, ISettingsService settingsService, IEventAggregator aggregator)
        {
            _clientService = clientService;
            _settingsService = settingsService;
            _aggregator = aggregator;
        }

        public IClientService ClientService => _clientService;

        public ISettingsService Settings => _settingsService;

        public IEventAggregator Aggregator => _aggregator;

        public int SessionId => _clientService.SessionId;

        public bool IsPremium => _clientService.IsPremium;
        public bool IsPremiumAvailable => _clientService.IsPremiumAvailable;


        private bool _isLoading;
        public virtual bool IsLoading
        {
            get => _isLoading;
            set => Set(ref _isLoading, value);
        }

        public virtual Task NavigatedToAsync(object parameter, NavigationMode mode, NavigationState state)
        {
            if (this is IHandle)
            {
                Subscribe();
            }

            return OnNavigatedToAsync(parameter, mode, state);
        }

        public virtual Task NavigatedFromAsync(NavigationState suspensionState, bool suspending)
        {
            if (this is IHandle)
            {
                Unsubscribe();
            }

            return OnNavigatedFromAsync(suspensionState, suspending);
        }

        public virtual void Subscribe()
        {

        }

        public void Unsubscribe()
        {
            Aggregator.Unsubscribe(this);
        }

        protected virtual void BeginOnUIThread(Windows.System.DispatcherQueueHandler action, Action fallback = null)
        {
            var dispatcher = Dispatcher;
            if (dispatcher == null)
            {
                dispatcher = WindowContext.Default()?.Dispatcher;
            }

            if (dispatcher != null)
            {
                dispatcher.Dispatch(action);
            }
            else if (fallback != null)
            {
                fallback();
            }
            else
            {
                try
                {
                    action();
                }
                catch { }
            }
        }
    }
}
