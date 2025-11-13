#!/usr/bin/env bash

pushd NativeAOT.Android
dotnet \
    $HOME/src/runtime2/artifacts/bin/coreclr/linux.x64.Debug/ilc/ilc.dll \
    @obj/Release/net10.0-android/android-x64/native/NativeAOT.Android.ilc.rsp \
    --waitfordebugger
popd
    # --parallelism 1 \
