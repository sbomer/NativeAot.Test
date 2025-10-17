#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import <MugenMvvm_iOS_Native/CollectionViewAdapter.h>

@interface NativeCollectionViewAdapter : NSObject <CollectionViewAdapter>

- (instancetype)initWithCollectionView:(UICollectionView *)collectionView;

@property(nonatomic, weak) UICollectionView *collectionView;

@property(nonatomic) BOOL animate;

@end
