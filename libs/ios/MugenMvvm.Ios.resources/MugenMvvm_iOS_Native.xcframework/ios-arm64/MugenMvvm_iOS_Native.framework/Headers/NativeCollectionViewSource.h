#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

@protocol CollectionViewSource;

@interface NativeCollectionViewSource : NSObject <UICollectionViewDataSource, UICollectionViewDelegate>

- (instancetype)initWithSource:(NSObject <CollectionViewSource> *)source;

@property(nonatomic, weak) NSObject <CollectionViewSource> *source;

@end