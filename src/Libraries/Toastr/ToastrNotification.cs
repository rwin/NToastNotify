using Microsoft.Extensions.Localization;
using NToastNotify.Helpers;
using NToastNotify.MessageContainers;
using static NToastNotify.Enums;

namespace NToastNotify
{
    public class ToastrNotification : ToastNotification<ToastrMessage, ToastrOptions>
    {
        private readonly IStringLocalizer<ToastrNotification> _localizer;

        public ToastrNotification(IMessageContainerFactory messageContainerFactory, IStringLocalizer<ToastrNotification> localizer) : base(messageContainerFactory)
        {
            _localizer = localizer;
        }

        public override void AddInfoToastMessage(string message, ILibraryOptions toastrOptions = null)
        {
            var options = OptionsHelpers.PrepareOptionsToastr(toastrOptions, NotificationTypesToastr.Info, _localizer.GetString("DefaultInfoTitle"));
            var toastMessage = new ToastrMessage(message ?? _localizer.GetString("DefaultInfoMessage"), options);
            AddMessage(toastMessage);
        }

        public override void AddWarningToastMessage(string message = null, ILibraryOptions toastrOptions = null)
        {
            var options = OptionsHelpers.PrepareOptionsToastr(toastrOptions, NotificationTypesToastr.Warning, _localizer.GetString("DefaultWarningTitle"));
            var toastMessage = new ToastrMessage(message ?? _localizer.GetString("DefaultWarningMessage"), options);
            AddMessage(toastMessage);
        }

        public override void AddErrorToastMessage(string message = null, ILibraryOptions toastrOptions = null)
        {
            var options = OptionsHelpers.PrepareOptionsToastr(toastrOptions, NotificationTypesToastr.Error, _localizer.GetString("DefaultErrorTitle"));
            var toastMessage = new ToastrMessage(message ?? _localizer.GetString("DefaultErrorMessage"), options);
            AddMessage(toastMessage);
        }

        public override void AddAlertToastMessage(string message = null, ILibraryOptions toastrOptions = null)
        {
            //because toastr js does not have an alert type.
            AddInfoToastMessage(message, toastrOptions);
        }

        public override void AddSuccessToastMessage(string message = null, ILibraryOptions toastrOptions = null)
        {
            var options = OptionsHelpers.PrepareOptionsToastr(toastrOptions, NotificationTypesToastr.Success, _localizer.GetString("DefaultSuccessTitle"));
            var toastMessage = new ToastrMessage(message ?? _localizer.GetString("DefaultSuccessMessage"), options);
            AddMessage(toastMessage);
        }

    }
}
