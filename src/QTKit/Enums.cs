//
// Copyright 2010, Novell, Inc.
//
// Permission is hereby granted, free of charge, to any person obtaining
// a copy of this software and associated documentation files (the
// "Software"), to deal in the Software without restriction, including
// without limitation the rights to use, copy, modify, merge, publish,
// distribute, sublicense, and/or sell copies of the Software, and to
// permit persons to whom the Software is furnished to do so, subject to
// the following conditions:
// 
// The above copyright notice and this permission notice shall be
// included in all copies or substantial portions of the Software.
// 
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF
// MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT HOLDERS BE
// LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY, WHETHER IN AN ACTION
// OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, OUT OF OR IN CONNECTION
// WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE SOFTWARE.
//
using System;
using System.Runtime.InteropServices;

namespace MonoMac.QTKit {

	[Flags]
	public enum TimeFlags {
		TimeIsIndefinite = 1
	}
	
	[Flags]
	public enum  QTMovieFileTypeOptions {
		StillImageTypes = 1 << 0,
		TranslatableTypes = 1 << 1,
		AggressiveTypes = 1 << 2,
		DynamicTypes = 1 << 3,
		CommonTypes = 0,
		AllTypes = 0xffff
	}

	public enum QTCaptureDeviceAVCTransportControls {
		NotPlaying,
		Playing
	}

	public enum QTCaptureDeviceAVCTransportControlsSpeed {
		FastestReverse = -19000,	
		VeryFastReverse = -16000,
		FastReverse = -13000,
		NormalReverse = -10000,
		SlowReverse = -7000,
		VerySlowReverse = -4000,
		SlowestReverse = -1000,
		Stopped = 0,	
		SlowestForward = 1000,
		VerySlowForward = 4000,
		SlowForward = 7000,
		NormalForward = 10000,
		FastForward = 13000,
		VeryFastForward = 16000,
		FastestForward = 19000,		
	}

	public enum QTCaptureDestination {
		NewFile = 1,
		OldFile = 2
	}

	public enum QTError {
		Unknown = -1,
		None,
		IncompatibleInput = 1002,
		IncompatibleOutput = 1003,
		InvalidInputsOrOutputs = 1100,
		DeviceAlreadyUsedbyAnotherSession = 1101,
		NoDataCaptured = 1200,
		SessionConfigurationChanged = 1201,
		DiskFull = 1202,
		DeviceWasDisconnected = 1203,
		MediaChanged = 1204,
		MaximumDurationReached = 1205,
		MaximumFileSizeReached = 1206,
		MediaDiscontinuity = 1207,
		MaximumNumberOfSamplesForFileFormatReached = 1208,
		DeviceNotConnected = 1300,
		DeviceInUseByAnotherApplication = 1301,
		DeviceExcludedByAnotherDevice = 1302,
	}

	public enum QTMediaType {
		Video, Sound, Text, Base, Mpeg, Music, TimeCode, Sprite, Flash, Movie, Tween, Type3D, Skin, Qtvr, Hint, Stream, Muxed, QuartzComposer
	}
} 