using Microsoft.Extensions.Localization;
using NToastNotify.Helpers;
using NToastNotify.MessageContainers;

namespace NToastNotify
{
    public class NotyNotification : ToastNotification<NotyMessage, NotyOptions>
    {
        private readonly IStringLocalizer<ToastrNotification> _localizer;

        public NotyNotification(IMessageContainerFactory messageContainerFactory, IStringLocalizer<ToastrNotification> localizer) : base(messageContainerFactory)
        {
            _localizer = localizer;
        }
        public override void AddSuccessToastMessage(string message = null, ILibraryOptions toastOptions = null)
        {
            var options = OptionsHelpers.PrepareOptionsNoty(toastOptions, message, Enums.NotificationTypesNoty.Success);
            var successNotyMessage = new NotyMessage(message ?? _localizer.GetString("DefaultSuccessMessage") , options);
            AddMessage(successNotyMessage);
        }

        public override void AddInfoToastMessage(string message = null, ILibraryOptions toastOptions = null)
        {
            var options = OptionsHelpers.PrepareOptionsNoty(toastOptions, message, Enums.NotificationTypesNoty.Info);
            var successNotyMessage = new NotyMessage(message ?? _localizer.GetString("DefaultInfoMessage"), options);
            AddMessage(successNotyMessage);
        }

        public override void AddAlertToastMessage(string message = null, ILibraryOptions toastOptions = null)
        {
            var options = OptionsHelpers.PrepareOptionsNoty(toastOptions, message, Enums.NotificationTypesNoty.Alert);
            var successNotyMessage = new NotyMessage(message ?? _localizer.GetString("DefaultAlertMessage"), options);
            AddMessage(successNotyMessage);
        }

        public override void AddWarningToastMessage(string message = null, ILibraryOptions toastOptions = null)
        {
            var options = OptionsHelpers.PrepareOptionsNoty(toastOptions, message, Enums.NotificationTypesNoty.Warning);
            var successNotyMessage = new NotyMessage(message ?? _localizer.GetString("DefaultWarningMessage"), options);
            AddMessage(successNotyMessage);
        }

        public override void AddErrorToastMessage(string message = null, ILibraryOptions toastOptions = null)
        {
            var options = OptionsHelpers.PrepareOptionsNoty(toastOptions, message, Enums.NotificationTypesNoty.Error);
            var successNotyMessage = new NotyMessage(message ?? _localizer.GetString("DefaultErrorMessage"), options);
            AddMessage(successNotyMessage);
        }
    }
}
