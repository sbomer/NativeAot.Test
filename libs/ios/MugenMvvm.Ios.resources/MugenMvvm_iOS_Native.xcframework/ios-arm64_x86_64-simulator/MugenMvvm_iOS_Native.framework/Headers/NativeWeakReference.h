#import <Foundation/Foundation.h>

@interface NativeWeakReference : NSObject

@property(nonatomic, weak, nullable) NSObject *target;

+ (NativeWeakReference *_Nonnull)get:(NSObject *_Nullable)target;

+ (NativeWeakReference *_Nullable)getOptional:(NSObject *_Nullable)target;

+ (BOOL)clear:(NSObject *_Nullable)target;

- (BOOL)isAlive;

- (NSObject *_Nullable)tryGetAttachedValues;

- (void)setAttachedValues:(NSObject *_Nullable)values;

@end