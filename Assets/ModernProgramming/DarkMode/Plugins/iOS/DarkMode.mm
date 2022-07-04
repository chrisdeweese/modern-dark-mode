#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

extern "C" {
    int DarkMode_getCurrentMode() {
        if (@available(iOS 13.0, *)) {
            if (UIScreen.mainScreen.traitCollection.userInterfaceStyle == UIUserInterfaceStyleDark) {
                return 2;
            }
            else if (UIScreen.mainScreen.traitCollection.userInterfaceStyle == UIUserInterfaceStyleLight) {
                return 1;
            }
            else {
                return 0; 
            }
        }
        return 0;
    }
}