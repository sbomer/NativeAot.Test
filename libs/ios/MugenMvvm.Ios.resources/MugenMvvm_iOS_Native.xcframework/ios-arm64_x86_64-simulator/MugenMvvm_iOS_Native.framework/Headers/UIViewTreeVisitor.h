#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

@protocol UIViewTreeVisitor <NSObject>

@required
- (BOOL)visit:(UIView *)view;

@end