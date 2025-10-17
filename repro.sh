#!/usr/bin/env bash

# ensure ANDROID_HOME is set and points to a valid Android SDK installation
if [ -z "$ANDROID_HOME" ]; then
    echo "ERROR: ANDROID_HOME is not set. Please set it to your Android SDK installation path."
    exit 1
fi
if [ ! -d "$ANDROID_HOME" ]; then
    echo "ERROR: ANDROID_HOME directory does not exist: $ANDROID_HOME"
    exit 1
fi

# for .NET 10, use NDK version 27.2.12479018.
export ANDROID_NDK_DIRECTORY="$ANDROID_HOME/ndk/27.2.12479018"
if [ ! -d "$ANDROID_NDK_DIRECTORY" ]; then
    echo "ERROR: ANDROID_NDK_DIRECTORY does not exist: $ANDROID_NDK_DIRECTORY"
    exit 1
fi

dotnet publish -f net10.0-android \
    -p:AndroidSdkDirectory="$ANDROID_HOME" \
    -p:AndroidNdkDirectory="$ANDROID_NDK_DIRECTORY"
