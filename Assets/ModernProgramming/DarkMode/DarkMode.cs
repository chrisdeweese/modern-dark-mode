using System.Runtime.InteropServices;
using UnityEngine;

namespace ModernProgramming
{
	public static class DarkMode
	{
		public enum Mode
		{
			Unspecified, // 0
			Light, // 1
			Dark // 2
		};
		
#if UNITY_IOS
		[DllImport("__Internal")]
		private static extern int DarkMode_getCurrentMode();
#endif
		
		/// <summary>
		/// Returns the current mode of the iOS or Android device.
		/// </summary>
		public static Mode CurrentMode
		{
			get
			{
#if UNITY_EDITOR
				return Mode.Unspecified;
#elif UNITY_ANDROID
				using (var class = new AndroidJavaClass("com.modernprogramming.darkmode.DarkMode")) {
					using (var playerClass = new AndroidJavaClass("com.unity3d.player.UnityPlayer")) {
						using (var activity = playerClass.GetStatic<AndroidJavaObject>("currentActivity")) {
							switch (class.CallStatic<int>("getCurrentMode", activity)) {
								case 1:
									return Mode.Light;
								case 2:
									return Mode.Dark;
							}
						}
					}
				}

				return Mode.Unspecified;
#elif UNITY_IOS
				switch (DarkMode_getCurrentMode()) {
					case 1:
						return Mode.Light;
					case 2:
						return Mode.Dark;
				}
				
				return Mode.Unspecified;
#else
				return Mode.Unspecified;
#endif
			}
		}
	}
}