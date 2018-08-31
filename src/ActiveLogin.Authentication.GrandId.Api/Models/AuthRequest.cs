﻿namespace ActiveLogin.Authentication.GrandId.Api.Models
{
    public class AuthRequest
    {
        public AuthRequest(DeviceOption deviceOption, string callbackUrl)
        {
            DeviceOption = deviceOption;
            CallbackUrl = callbackUrl;
        }

        public DeviceOption DeviceOption { get; set; }

        public string CallbackUrl { get; set; }
    }
}