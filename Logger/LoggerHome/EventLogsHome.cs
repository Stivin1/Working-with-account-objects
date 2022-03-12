﻿using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using OpenSourceEnity.Logger.LoggerMapper;
using OpenSourceEnity.Models.Entities.SystemEntities;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OpenSourceEnity.Logger.LoggerHome
{
    public class EventLogsHome
    {
        public static void EventRequestInfo(ILogger logger, IWebHostEnvironment Environment, User user)
        {
            EventRequestHomeInfo(logger, user, null);

            SetEventRequestInfoJson(Environment, user);
        }

        public static void EventRequestErrorInfo(ILogger logger, IWebHostEnvironment Environment, User user, Exception? exception = null)
        {
            EventRequestErrorHomeInfo(logger, user, exception);

            SetEventRequestErrorInfoJson(Environment, user, exception);
        }

        private static Action<ILogger, User, Exception?> EventRequestHomeInfo = LoggerMessage.Define<User>
            (LogLevel.Information, EventLogsHelperHome.EventRequestHomeInfo, "Authorization was successful {User.UserName}");

        private static Action<ILogger, User, Exception?> EventRequestErrorHomeInfo = LoggerMessage.Define<User>
            (LogLevel.Information, EventLogsHelperHome.EventRequestHomeErrorInfo, "Getting user data was not successful {User.UserName}");

        private static void SetEventRequestInfoJson(IWebHostEnvironment Environment, User User)
        {
            if (User != null)
            {
                LoggerMapperUser loggerMapperUser = new LoggerMapperUser
                {
                    Id = User.Id,
                    UserName = User.UserName,
                    DateOperation = DateTime.Now.ToString(),
                    DescriptionOperation = "Авторизация прошла успешно"
                };

                var json = JsonConvert.SerializeObject(loggerMapperUser, new JsonSerializerSettings()
                {

                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    Formatting = Formatting.Indented
                });


                using (FileStream stream = new FileStream(Environment.ContentRootPath
                    + "/Logger/" + "/LoggerFiles/"
                    + string.Format("EventLogsInfoHome({0}).txt", User.Id)
                    , FileMode.Create
                    , FileAccess.Write))
                {
                    using (StreamWriter str = new StreamWriter(stream))
                    {
                        str.WriteLine(json);
                        str.Close();
                    }
                    stream.Close();
                }
            }
        }

        private static void SetEventRequestErrorInfoJson(IWebHostEnvironment Environment, User User, Exception? exception = null)
        {
            if (User != null)
            {
                LoggerMapperUser loggerMapperUser = new LoggerMapperUser
                {
                    Id = User.Id,
                    UserName = User.UserName,
                    DateOperation = DateTime.Now.ToString(),
                    DescriptionOperation = "Получение данных о пользователе прошло не успешно: " + exception.Message
                };

                var json = JsonConvert.SerializeObject(loggerMapperUser, new JsonSerializerSettings()
                {

                    ReferenceLoopHandling = ReferenceLoopHandling.Ignore,
                    Formatting = Formatting.Indented
                });

                using (FileStream stream = new FileStream(
                    Environment.ContentRootPath
                    + "/Logger/"
                    + "/LoggerFiles/"
                    + string.Format("EeventLogsErrorHome({0}).txt", User.Id)
                    , FileMode.Create
                    , FileAccess.Write))
                {
                    using (StreamWriter str = new StreamWriter(stream))
                    {
                        str.WriteLine(json);
                        str.Close();
                    }
                    stream.Close();
                }
            }
        }
    }
}
