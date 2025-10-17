#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

@protocol CollectionViewSource <NSObject>

@required
- (NSObject *)behavior;

@required
- (NSInteger)numberOfItems:(NSInteger)section;

@required
- (NSString *)cellIdForItemAtIndex:(NSInteger)index section:(NSInteger)section;

@required
- (void)onGetCell:(UIView *)cell index:(NSInteger)index section:(NSInteger)section initialized:(BOOL)initialized;

@required
- (BOOL)isLoadMoreRequired:(NSInteger)index section:(NSInteger)section;

@optional
- (NSInteger)numberOfSections;

@optional
- (void)didEndDisplayingCell:(UIView *)cell index:(NSInteger)index section:(NSInteger)section;

@optional
- (void)willDisplayCell:(UIView *)cell index:(NSInteger)index section:(NSInteger)section;

@end
