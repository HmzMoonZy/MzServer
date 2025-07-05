/**
 * Auto generated, do not edit it server
 */
using System;
using System.Collections;
using System.Collections.Generic;
using HotFix.Cfg;
using NLog;

namespace Geek.Server.Config
{
	public class GameDataManager
	{
		private static readonly NLog.Logger LOGGER = LogManager.GetCurrentClassLogger();
		
		public static GameDataManager Instance { get; private set; }
		
		private GameDataManager() { }
		
		/// <summary>
		/// 最近刷新时间
		/// </summary>
		public DateTime ReloadTime { get; private set; }
		
        public static (bool, string) ReloadAll()
        {
            try
            {
	            Instance = new();
                Instance.LoadAll(true);
                Instance.ReloadTime = DateTime.Now;
				return (true, "");
            }
            catch (Exception e)
            {
                LOGGER.Error(e.Message);
				return (false, e.Message);
            }
        }
        
		private void LoadAll(bool forceReload = false)
		{
			
		}
	}
}