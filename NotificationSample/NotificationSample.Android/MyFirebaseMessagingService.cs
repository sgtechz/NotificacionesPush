using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Firebase.Messaging;

namespace NotificationSample.Droid
{
    [Service]
    [IntentFilter(new[] { "com.google.firebase.MESSAGING_EVENT" })]
    public class MyFirebaseMessagingService : FirebaseMessagingService
    {
        public MyFirebaseMessagingService()
        {

        }

        //public void OnNewToken(string token)
        //{
        //    base.OnNewToken(token);

        //    Preferences.Set("TokenFirebase", token);
        //    sedRegisterToken(token);
        //}
        public override void OnMessageReceived(RemoteMessage message)
        {
            base.OnMessageReceived(message);
            new NotificationHelper().CreateNotification(message.GetNotification().Title, message.GetNotification().Body);
        }

        //public void sedRegisterToken(string token)
        //{
        //    //Tu código para registrar el token a tu servidor y base de datos
        //}
    }
}