#import <Foundation/Foundation.h>

@protocol HostAppProtocol <NSObject>

@required
- (void)onLoadMore:(UIView *)view;

@required
- (void)onTextChanged:(UIView *)view;

@required
- (void)onFocusChanged:(UIView *)view newView:(UIView*)newView;

@end
