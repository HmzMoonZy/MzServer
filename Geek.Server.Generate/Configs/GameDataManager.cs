/**
 * Auto generated, do not edit it server
 */
using System;
using System.Collections;
using System.Collections.Generic;
using Luban;
using HotFix.Cfg;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NLog;
using NLog.Fluent;

namespace Geek.Server.Config
{
	public class GameDataManager
	{
		private static readonly NLog.Logger LOGGER = LogManager.GetCurrentClassLogger();
		public static GameDataManager Instance { get; private set; }
		public static Tables T => GameDataManager.Instance.Tables;
		
		private GameDataManager() { }

		public Tables Tables;
		
		/// <summary>
		/// 最近刷新时间
		/// </summary>
		public DateTime ReloadTime { get; private set; }
		
        public static (bool, string) ReloadAll()
        {
            try
            {
	            Instance = new();
                Instance.LoadAll();
                Instance.ReloadTime = DateTime.Now;
				return (true, "");
            }
            catch (Exception e)
            {
                LOGGER.Error(e.Message);
				return (false, e.Message);
            }
        }
        
		private void LoadAll()
		{
			var dataDir = new DirectoryInfo(Path.Combine(Environment.CurrentDirectory, "gamedata"));
			if (!dataDir.Exists)
			{
				LOGGER.Error($"gamedata目录不存在");
				return;
			}
			
			try
			{
				Delegate processor = null;

				var constructor = typeof(Tables).GetConstructors()[0];
				var parameter = constructor.GetParameters()[0];
				var loaderReturnType = parameter.ParameterType.GetGenericArguments()[1];

				if (loaderReturnType == typeof(Luban.ByteBuf))
				{
					processor = new Func<string, Luban.ByteBuf>(BinLoader);
				}
				else if (loaderReturnType == typeof(JArray))
				{
					processor = new Func<string, JArray>(JsonLoader);
				}
				else
				{
					throw new NotImplementedException();
				}

				Tables = constructor.Invoke(new object[] { processor }) as Tables;
			}
			catch (Exception e)
			{
				LOGGER.Error("ClientDB Init Error!");
				LOGGER.Error(e.Message);
				return;
			}


			Luban.ByteBuf BinLoader(string sourceName)
			{
				var files = dataDir.GetFiles($"{sourceName}.bytes");
				if (files.Length == 0)
				{
					LOGGER.Error($"can not find conf data: {sourceName}.bytes");
					return null;
				}
				var dataFile = files[0];
				var source = File.ReadAllBytes(dataFile.FullName);
				return new ByteBuf(source);
			}

			JArray JsonLoader(string sourceName)
			{
				var files = dataDir.GetFiles($"{sourceName}.bytes");
				if (files.Length == 0)
				{
					LOGGER.Error($"can not find conf data: {sourceName}.bytes");
					return null;
				}
				var dataFile = files[0];
				var source = File.ReadAllText(dataFile.FullName);
				return JsonConvert.DeserializeObject<JArray>(source);
			}
		}
	}
}