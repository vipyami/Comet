﻿using HotUI.Android.Controls;
using HotUI.Android.Handlers;
using HotUI.Android.Services;

namespace HotUI.Android
{
    public static class UI
    {
        static bool hasInit;

        public static void Init()
        {
            if (hasInit)
                return;
            hasInit = true;
            Registrar.Handlers.Register<Button, ButtonHandler>();
            Registrar.Handlers.Register<Toggle, ToggleHandler>();
            Registrar.Handlers.Register<TextField, TextFieldHandler>();
            Registrar.Handlers.Register<Text, TextHandler>();
            Registrar.Handlers.Register<VStack, VStackHandler>();
            Registrar.Handlers.Register<HStack, HStackHandler>();
            //Registrar.Handlers.Register<WebView, WebViewHandler> ();
            Registrar.Handlers.Register<ScrollView, ScrollViewHandler>();
			Registrar.Handlers.Register<Image, ImageHandler> ();
			Registrar.Handlers.Register<ListView, ListViewHandler> ();
			Registrar.Handlers.Register<View, ViewHandler>();
            Registrar.Handlers.Register<ContentView, ContentViewHandler>();
            Registrar.Handlers.Register<ViewRepresentable, ViewRepresentableHandler>();

            Device.PerformInvokeOnMainThread = (a) => AndroidContext.CurrentContext.RunOnUiThread(a);
            Device.GraphicsService = new AndroidGraphicsService();
            ModalView.PerformPresent = ModalManager.ShowModal;
            ModalView.PerformDismiss = ModalManager.DismisModal;

        }
    }
}