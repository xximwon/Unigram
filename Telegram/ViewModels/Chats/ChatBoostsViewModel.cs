﻿using System.Threading.Tasks;
using Telegram.Collections;
using Telegram.Common;
using Telegram.Navigation;
using Telegram.Navigation.Services;
using Telegram.Services;
using Telegram.Td.Api;
using Telegram.Views;
using Telegram.Views.Popups;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Navigation;

namespace Telegram.ViewModels.Chats
{
    public class ChatBoostsViewModel : ViewModelBase, IIncrementalCollectionOwner
    {
        private long _chatId;
        private string _nextOffset = string.Empty;

        public ChatBoostsViewModel(IClientService clientService, ISettingsService settingsService, IEventAggregator aggregator)
            : base(clientService, settingsService, aggregator)
        {
            Items = new IncrementalCollection<ChatBoost>(this);
        }

        public IncrementalCollection<ChatBoost> Items { get; }

        private int _level;
        public int Level
        {
            get => _level;
            set => Set(ref _level, value);
        }

        private int _boostCount;
        public int BoostCount
        {
            get => _boostCount;
            set => Set(ref _boostCount, value);
        }

        private int _currentLevelBoostCount;
        public int CurrentLevelBoostCount
        {
            get => _currentLevelBoostCount;
            set => Set(ref _currentLevelBoostCount, value);
        }

        private int _nextLevelBoostCount;
        public int NextLevelBoostCount
        {
            get => _nextLevelBoostCount;
            set => Set(ref _nextLevelBoostCount, value);
        }

        private int _premiumMemberCount;
        public int PremiumMemberCount
        {
            get => _premiumMemberCount;
            set => Set(ref _premiumMemberCount, value);
        }

        private double _premiumMemberPercentage;
        public double PremiumMemberPercentage
        {
            get => _premiumMemberPercentage;
            set => Set(ref _premiumMemberPercentage, value);
        }

        private string _link;
        public string Link
        {
            get => _link;
            set => Set(ref _link, value);
        }

        protected override async Task OnNavigatedToAsync(object parameter, NavigationMode mode, NavigationState state)
        {
            if (parameter is long chatId)
            {
                _chatId = chatId;

                var response = await ClientService.SendAsync(new GetChatBoostStatus(chatId));
                if (response is ChatBoostStatus status)
                {
                    Level = status.Level;
                    BoostCount = status.BoostCount;
                    CurrentLevelBoostCount = status.CurrentLevelBoostCount;
                    NextLevelBoostCount = status.NextLevelBoostCount;
                    PremiumMemberCount = status.PremiumMemberCount;
                    PremiumMemberPercentage = status.PremiumMemberPercentage;
                }

                response = await ClientService.SendAsync(new GetChatBoostLink(chatId));
                if (response is ChatBoostLink link)
                {
                    Link = link.Link.Replace("https://", string.Empty);
                }
            }
        }

        public async Task<LoadMoreItemsResult> LoadMoreItemsAsync(uint count)
        {
            var total = 0u;

            var response = await ClientService.SendAsync(new GetChatBoosts(_chatId, _nextOffset, 50));
            if (response is FoundChatBoosts boosts)
            {
                foreach (var item in boosts.Boosts)
                {
                    total++;
                    Items.Add(item);
                }

                _nextOffset = boosts.NextOffset;
                HasMoreItems = false;
            }

            return new LoadMoreItemsResult
            {
                Count = total
            };
        }

        public bool HasMoreItems { get; private set; } = true;

        public void CopyLink()
        {
            MessageHelper.CopyLink("https://" + Link);
        }

        public async void ShareLink()
        {
            await ShowPopupAsync(typeof(ChooseChatsPopup), new ChooseChatsConfigurationPostLink(new HttpUrl("https://" + Link)));
        }

        public void OpenProfile(ChatBoost chatBoost)
        {
            if (chatBoost.UserId != ClientService.Options.MyId)
            {
                NavigationService.Navigate(typeof(ProfilePage), chatBoost.UserId);
            }
        }
    }
}
