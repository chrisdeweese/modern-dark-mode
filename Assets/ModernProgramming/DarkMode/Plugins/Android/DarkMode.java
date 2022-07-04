package com.modernprogramming.darkmode;

import android.view.ContextThemeWrapper;
import android.content.res.Configuration;
import android.os.Build;

public class DarkMode 
{
    public static int getCurrentMode(ContextThemeWrapper ctw) 
    {
        if (Build.VERSION.SDK_INT < 29) // Android Q is the minimum requirement
        {  
            return 0;  // Unspecified
        }

        switch (ctw.getResources().getConfiguration().uiMode & Configuration.UI_MODE_NIGHT_MASK) 
        {
            case Configuration.UI_MODE_NIGHT_NO: 
                return 1; // Light mode
            case Configuration.UI_MODE_NIGHT_YES:
                return 2; // Dark mode
        }
        
        return 0;  // Unspecified
    }
}