#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>

@protocol CollectionViewAdapter <NSObject>

@required
- (BOOL)isAlive;

@required
- (void)reload:(void (NS_NOESCAPE ^ _Nullable)(void))completion;

@required
- (void)performBatchUpdates:(void (NS_NOESCAPE ^ _Nullable)(void))updates completion:(void (^ _Nullable)(BOOL finished))completion;

@required
- (void)batchUpdate:(int32_t *_Nonnull)buffer removes:(int32_t)removes inserts:(int32_t)inserts moves:(int32_t)moves withSections:(BOOL)withSections;

@required
- (void)onInserted:(int32_t)index section:(int32_t)section;

@required
- (void)onRemoved:(int32_t)index section:(int32_t)section;

@required
- (void)onMoved:(int32_t)from to:(int32_t)to section:(int32_t)section;

@required
- (void)onChanged:(int32_t)index section:(int32_t)section;

@end
