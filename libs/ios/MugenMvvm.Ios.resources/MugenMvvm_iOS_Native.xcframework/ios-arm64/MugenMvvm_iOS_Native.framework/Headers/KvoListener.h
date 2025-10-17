#import <Foundation/Foundation.h>

@protocol KvoListener <NSObject>

- (void)onChanged:(NSObject *)target;

@end