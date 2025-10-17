#import <Foundation/Foundation.h>
#import <UIKit/UIKit.h>
#import <MugenMvvm_iOS_Native/KvoListener.h>
#import <MugenMvvm_iOS_Native/UIViewTreeVisitor.h>
#import <MugenMvvm_iOS_Native/HostAppProtocol.h>

#define InitializedStateMask 1

@interface MugenNativeUtils : NSObject

+ (void)addWeakObserver:(NSObject * _Nonnull)source target:(NSObject <KvoListener> * _Nonnull)listener path:(NSString * _Nonnull)path;

+ (void)initializeHost:(NSObject <HostAppProtocol> *_Nonnull)host;

+ (NSObject *_Nullable)tryGetAttachedValues:(NSObject *_Nullable)target;

+ (void)setAttachedValues:(NSObject *_Nullable)target values:(NSObject *_Nullable)values;

+ (NSInteger)getControllersCount:(UINavigationController *_Nonnull)controller;

+ (UIViewController *_Nullable)getLastController:(UINavigationController *_Nonnull)controller;

+ (BOOL)bringToFront:(UINavigationController *_Nonnull)source controller:(UIViewController *_Nonnull)controller animate:(BOOL)animate clearBackStack:(BOOL)clearBackStack;

+ (NSInteger)indexOfController:(UINavigationController *_Nonnull)source controller:(UIViewController *_Nonnull)controller;

+ (void)removeControllerAt:(UINavigationController *_Nonnull)source index:(NSInteger)index animate:(BOOL)animate;

+ (BOOL)visitViews:(UIView *_Nonnull)view visitor:(NSObject <UIViewTreeVisitor> *_Nonnull)visitor includeRoot:(BOOL)includeRoot recursively:(BOOL)recursively;

+ (void)batchUpdate:(UICollectionView *_Nullable)view buffer:(int32_t *_Nonnull)buffer removes:(int32_t)removes inserts:(int32_t)inserts moves:(int32_t)moves
       withSections:(BOOL)withSections animate:(BOOL)animate;

+ (void)onInserted:(UICollectionView *_Nullable)view index:(int32_t)index count:(int32_t)count section:(int32_t)section animate:(BOOL)animate;

+ (void)onRemoved:(UICollectionView *_Nullable)view index:(int32_t)index count:(int32_t)count section:(int32_t)section animate:(BOOL)animate;

+ (void)onMoved:(UICollectionView *_Nullable)view from:(int32_t)from to:(int32_t)to section:(int32_t)section animate:(BOOL)animate;

+ (void)onChanged:(UICollectionView *_Nullable)view index:(int32_t)index count:(int32_t)count section:(int32_t)section animate:(BOOL)animate;

+ (void)raiseLoadMore:(UIView *_Nonnull)view;

+ (UIView *_Nonnull)getArrangedViewByIndex:(UIStackView *_Nonnull)view index:(int32_t)index;

+ (void)clearArrangedSubviews:(UIStackView *_Nonnull)view;

+ (void)setElevation:(CGFloat)elevation view:(UIView * _Nonnull)view;

+ (void)_updateMaskPathForView:(UIView *_Nonnull)v mask:(CAShapeLayer *_Nonnull)mask radii:(CGRect)r;

+ (CGRect)cornersForView:(UIView *_Nonnull)view;

+ (CGRect)cornersForButton:(UIButton *_Nonnull)button;

+ (void)applyCorners:(CGRect)radii toView:(UIView *_Nonnull)view;

+ (void)applyCorners:(CGRect)radii toButton:(UIButton *_Nonnull)button;

@end
