#import <UIKit/UIKit.h>

NS_ASSUME_NONNULL_BEGIN

@interface MugenRefreshHostControl : UIControl

@property (nonatomic, weak, nullable) UICollectionView *collectionView;

@property (nonatomic, strong, readonly) UIRefreshControl *refreshControl;

@property (nonatomic, assign, getter=isRefreshing) BOOL refreshing;

- (instancetype)initWithCollectionView:(UICollectionView *)collectionView NS_DESIGNATED_INITIALIZER;

- (instancetype)initWithFrame:(CGRect)frame NS_UNAVAILABLE;

- (instancetype)initWithCoder:(NSCoder *)coder NS_UNAVAILABLE;

- (void)invalidate;

- (void)hostViewWillDisappear;

- (void)hostViewDidAppear;

@end

NS_ASSUME_NONNULL_END
