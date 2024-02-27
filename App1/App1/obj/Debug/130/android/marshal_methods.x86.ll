; ModuleID = 'obj\Debug\130\android\marshal_methods.x86.ll'
source_filename = "obj\Debug\130\android\marshal_methods.x86.ll"
target datalayout = "e-m:e-p:32:32-p270:32:32-p271:32:32-p272:64:64-f64:32:64-f80:32-n8:16:32-S128"
target triple = "i686-unknown-linux-android"


%struct.MonoImage = type opaque

%struct.MonoClass = type opaque

%struct.MarshalMethodsManagedClass = type {
	i32,; uint32_t token
	%struct.MonoClass*; MonoClass* klass
}

%struct.MarshalMethodName = type {
	i64,; uint64_t id
	i8*; char* name
}

%class._JNIEnv = type opaque

%class._jobject = type {
	i8; uint8_t b
}

%class._jclass = type {
	i8; uint8_t b
}

%class._jstring = type {
	i8; uint8_t b
}

%class._jthrowable = type {
	i8; uint8_t b
}

%class._jarray = type {
	i8; uint8_t b
}

%class._jobjectArray = type {
	i8; uint8_t b
}

%class._jbooleanArray = type {
	i8; uint8_t b
}

%class._jbyteArray = type {
	i8; uint8_t b
}

%class._jcharArray = type {
	i8; uint8_t b
}

%class._jshortArray = type {
	i8; uint8_t b
}

%class._jintArray = type {
	i8; uint8_t b
}

%class._jlongArray = type {
	i8; uint8_t b
}

%class._jfloatArray = type {
	i8; uint8_t b
}

%class._jdoubleArray = type {
	i8; uint8_t b
}

; assembly_image_cache
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 4
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [186 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 51
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 73
	i32 165246403, ; 2: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 29
	i32 209399409, ; 3: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 27
	i32 230216969, ; 4: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 47
	i32 232815796, ; 5: System.Web.Services => 0xde07cb4 => 89
	i32 261689757, ; 6: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 33
	i32 280482487, ; 7: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 46
	i32 318968648, ; 8: Xamarin.AndroidX.Activity.dll => 0x13031348 => 19
	i32 321597661, ; 9: System.Numerics => 0x132b30dd => 12
	i32 342366114, ; 10: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 48
	i32 385762202, ; 11: System.Memory.dll => 0x16fe439a => 10
	i32 441335492, ; 12: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 32
	i32 442521989, ; 13: Xamarin.Essentials => 0x1a605985 => 70
	i32 450948140, ; 14: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 45
	i32 465846621, ; 15: mscorlib => 0x1bc4415d => 5
	i32 469710990, ; 16: System.dll => 0x1bff388e => 8
	i32 476646585, ; 17: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 46
	i32 486930444, ; 18: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 55
	i32 526420162, ; 19: System.Transactions.dll => 0x1f6088c2 => 80
	i32 548916678, ; 20: Microsoft.Bcl.AsyncInterfaces => 0x20b7cdc6 => 3
	i32 605376203, ; 21: System.IO.Compression.FileSystem => 0x24154ecb => 84
	i32 627609679, ; 22: Xamarin.AndroidX.CustomView => 0x2568904f => 38
	i32 639843206, ; 23: Xamarin.AndroidX.Emoji2.ViewsHelper.dll => 0x26233b86 => 44
	i32 643868501, ; 24: System.Net => 0x2660a755 => 11
	i32 662205335, ; 25: System.Text.Encodings.Web.dll => 0x27787397 => 16
	i32 663517072, ; 26: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 67
	i32 666292255, ; 27: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 25
	i32 690569205, ; 28: System.Xml.Linq.dll => 0x29293ff5 => 90
	i32 691348768, ; 29: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 76
	i32 700284507, ; 30: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 74
	i32 709365442, ; 31: App1 => 0x2a480ec2 => 0
	i32 775507847, ; 32: System.IO.Compression => 0x2e394f87 => 83
	i32 790371945, ; 33: Xamarin.AndroidX.CustomView.PoolingContainer.dll => 0x2f1c1e69 => 39
	i32 809851609, ; 34: System.Drawing.Common.dll => 0x30455ad9 => 82
	i32 843511501, ; 35: Xamarin.AndroidX.Print => 0x3246f6cd => 57
	i32 928116545, ; 36: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 73
	i32 967690846, ; 37: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 48
	i32 1012816738, ; 38: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 61
	i32 1031528504, ; 39: Xamarin.Google.ErrorProne.Annotations.dll => 0x3d7be038 => 72
	i32 1035644815, ; 40: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 24
	i32 1052210849, ; 41: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 52
	i32 1084122840, ; 42: Xamarin.Kotlin.StdLib => 0x409e66d8 => 75
	i32 1098259244, ; 43: System => 0x41761b2c => 8
	i32 1175144683, ; 44: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 65
	i32 1204270330, ; 45: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 25
	i32 1246548578, ; 46: Xamarin.AndroidX.Collection.Jvm.dll => 0x4a4cd262 => 30
	i32 1264511973, ; 47: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0x4b5eebe5 => 62
	i32 1264890200, ; 48: Xamarin.KotlinX.Coroutines.Core.dll => 0x4b64b158 => 77
	i32 1267360935, ; 49: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 66
	i32 1275534314, ; 50: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 76
	i32 1278448581, ; 51: Xamarin.AndroidX.Annotation.Jvm => 0x4c3393c5 => 22
	i32 1293217323, ; 52: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 41
	i32 1365406463, ; 53: System.ServiceModel.Internals.dll => 0x516272ff => 88
	i32 1376866003, ; 54: Xamarin.AndroidX.SavedState => 0x52114ed3 => 61
	i32 1406073936, ; 55: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 34
	i32 1411638395, ; 56: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 14
	i32 1462112819, ; 57: System.IO.Compression.dll => 0x57261233 => 83
	i32 1469204771, ; 58: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 23
	i32 1582372066, ; 59: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 40
	i32 1592978981, ; 60: System.Runtime.Serialization.dll => 0x5ef2ee25 => 87
	i32 1597949149, ; 61: Xamarin.Google.ErrorProne.Annotations => 0x5f3ec4dd => 72
	i32 1622152042, ; 62: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 54
	i32 1624863272, ; 63: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 69
	i32 1635184631, ; 64: Xamarin.AndroidX.Emoji2.ViewsHelper => 0x6176eff7 => 44
	i32 1636350590, ; 65: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 37
	i32 1639515021, ; 66: System.Net.Http.dll => 0x61b9038d => 86
	i32 1657153582, ; 67: System.Runtime => 0x62c6282e => 15
	i32 1658241508, ; 68: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 63
	i32 1658251792, ; 69: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 71
	i32 1670060433, ; 70: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 33
	i32 1729485958, ; 71: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 28
	i32 1776026572, ; 72: System.Core.dll => 0x69dc03cc => 7
	i32 1788241197, ; 73: Xamarin.AndroidX.Fragment => 0x6a96652d => 45
	i32 1796167890, ; 74: Microsoft.Bcl.AsyncInterfaces.dll => 0x6b0f58d2 => 3
	i32 1808609942, ; 75: Xamarin.AndroidX.Loader => 0x6bcd3296 => 54
	i32 1813058853, ; 76: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 75
	i32 1813201214, ; 77: Xamarin.Google.Android.Material => 0x6c13413e => 71
	i32 1867746548, ; 78: Xamarin.Essentials.dll => 0x6f538cf4 => 70
	i32 1885316902, ; 79: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 26
	i32 1919157823, ; 80: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 56
	i32 2011961780, ; 81: System.Buffers.dll => 0x77ec19b4 => 6
	i32 2019465201, ; 82: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 52
	i32 2055257422, ; 83: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 49
	i32 2079903147, ; 84: System.Runtime.dll => 0x7bf8cdab => 15
	i32 2090596640, ; 85: System.Numerics.Vectors => 0x7c9bf920 => 13
	i32 2188064486, ; 86: System.Json.dll => 0x826b36e6 => 9
	i32 2201107256, ; 87: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 78
	i32 2201231467, ; 88: System.Net.Http => 0x8334206b => 86
	i32 2217644978, ; 89: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 65
	i32 2244775296, ; 90: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 55
	i32 2256548716, ; 91: Xamarin.AndroidX.MultiDex => 0x8680336c => 56
	i32 2279755925, ; 92: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 59
	i32 2315684594, ; 93: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 20
	i32 2403452196, ; 94: Xamarin.AndroidX.Emoji2.dll => 0x8f41c524 => 43
	i32 2465532216, ; 95: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 32
	i32 2471841756, ; 96: netstandard.dll => 0x93554fdc => 1
	i32 2475788418, ; 97: Java.Interop.dll => 0x93918882 => 2
	i32 2501346920, ; 98: System.Data.DataSetExtensions => 0x95178668 => 81
	i32 2505896520, ; 99: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 51
	i32 2570120770, ; 100: System.Text.Encodings.Web => 0x9930ee42 => 16
	i32 2581819634, ; 101: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 66
	i32 2605712449, ; 102: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 78
	i32 2620871830, ; 103: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 37
	i32 2624644809, ; 104: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 42
	i32 2671474046, ; 105: Xamarin.KotlinX.Coroutines.Core => 0x9f3b757e => 77
	i32 2701096212, ; 106: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 63
	i32 2732626843, ; 107: Xamarin.AndroidX.Activity => 0xa2e0939b => 19
	i32 2737747696, ; 108: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 23
	i32 2770495804, ; 109: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 74
	i32 2778768386, ; 110: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 68
	i32 2779977773, ; 111: Xamarin.AndroidX.ResourceInspection.Annotation.dll => 0xa5b3182d => 60
	i32 2810250172, ; 112: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 34
	i32 2819470561, ; 113: System.Xml.dll => 0xa80db4e1 => 18
	i32 2821294376, ; 114: Xamarin.AndroidX.ResourceInspection.Annotation => 0xa8298928 => 60
	i32 2853208004, ; 115: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 68
	i32 2855708567, ; 116: Xamarin.AndroidX.Transition => 0xaa36a797 => 64
	i32 2887636118, ; 117: System.Net.dll => 0xac1dd496 => 11
	i32 2903344695, ; 118: System.ComponentModel.Composition => 0xad0d8637 => 85
	i32 2905242038, ; 119: mscorlib.dll => 0xad2a79b6 => 5
	i32 2916838712, ; 120: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 69
	i32 2919462931, ; 121: System.Numerics.Vectors.dll => 0xae037813 => 13
	i32 2921128767, ; 122: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 21
	i32 2978675010, ; 123: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 41
	i32 2996846495, ; 124: Xamarin.AndroidX.Lifecycle.Process.dll => 0xb2a03f9f => 50
	i32 3016983068, ; 125: Xamarin.AndroidX.Startup.StartupRuntime => 0xb3d3821c => 62
	i32 3024354802, ; 126: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 47
	i32 3111772706, ; 127: System.Runtime.Serialization => 0xb979e222 => 87
	i32 3124832203, ; 128: System.Threading.Tasks.Extensions => 0xba4127cb => 92
	i32 3201217166, ; 129: System.Json => 0xbeceb28e => 9
	i32 3204380047, ; 130: System.Data.dll => 0xbefef58f => 79
	i32 3211777861, ; 131: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 40
	i32 3247949154, ; 132: Mono.Security => 0xc197c562 => 91
	i32 3258312781, ; 133: Xamarin.AndroidX.CardView => 0xc235e84d => 28
	i32 3265893370, ; 134: System.Threading.Tasks.Extensions.dll => 0xc2a993fa => 92
	i32 3317135071, ; 135: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 38
	i32 3317144872, ; 136: System.Data => 0xc5b79d28 => 79
	i32 3340431453, ; 137: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 26
	i32 3345895724, ; 138: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xc76e512c => 58
	i32 3358260929, ; 139: System.Text.Json => 0xc82afec1 => 17
	i32 3362522851, ; 140: Xamarin.AndroidX.Core => 0xc86c06e3 => 36
	i32 3366347497, ; 141: Java.Interop => 0xc8a662e9 => 2
	i32 3374999561, ; 142: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 59
	i32 3395150330, ; 143: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 14
	i32 3404865022, ; 144: System.ServiceModel.Internals => 0xcaf21dfe => 88
	i32 3405233483, ; 145: Xamarin.AndroidX.CustomView.PoolingContainer => 0xcaf7bd4b => 39
	i32 3414721009, ; 146: App1.dll => 0xcb8881f1 => 0
	i32 3429136800, ; 147: System.Xml => 0xcc6479a0 => 18
	i32 3430777524, ; 148: netstandard => 0xcc7d82b4 => 1
	i32 3441283291, ; 149: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 42
	i32 3476120550, ; 150: Mono.Android => 0xcf3163e6 => 4
	i32 3485117614, ; 151: System.Text.Json.dll => 0xcfbaacae => 17
	i32 3486566296, ; 152: System.Transactions => 0xcfd0c798 => 80
	i32 3493954962, ; 153: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 31
	i32 3509114376, ; 154: System.Xml.Linq => 0xd128d608 => 90
	i32 3567349600, ; 155: System.ComponentModel.Composition.dll => 0xd4a16f60 => 85
	i32 3627220390, ; 156: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 57
	i32 3633644679, ; 157: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 21
	i32 3641597786, ; 158: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 49
	i32 3672681054, ; 159: Mono.Android.dll => 0xdae8aa5e => 4
	i32 3676310014, ; 160: System.Web.Services.dll => 0xdb2009fe => 89
	i32 3682565725, ; 161: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 27
	i32 3684561358, ; 162: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 31
	i32 3689375977, ; 163: System.Drawing.Common => 0xdbe768e9 => 82
	i32 3706696989, ; 164: Xamarin.AndroidX.Core.Core.Ktx.dll => 0xdcefb51d => 35
	i32 3718780102, ; 165: Xamarin.AndroidX.Annotation => 0xdda814c6 => 20
	i32 3786282454, ; 166: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 29
	i32 3829621856, ; 167: System.Numerics.dll => 0xe4436460 => 12
	i32 3885922214, ; 168: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 64
	i32 3888767677, ; 169: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0xe7c9e2bd => 58
	i32 3896760992, ; 170: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 36
	i32 3910130544, ; 171: Xamarin.AndroidX.Collection.Jvm => 0xe90fdb70 => 30
	i32 3920810846, ; 172: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 84
	i32 3921031405, ; 173: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 67
	i32 3945713374, ; 174: System.Data.DataSetExtensions.dll => 0xeb2ecede => 81
	i32 3955647286, ; 175: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 24
	i32 3959773229, ; 176: Xamarin.AndroidX.Lifecycle.Process => 0xec05582d => 50
	i32 4015948917, ; 177: Xamarin.AndroidX.Annotation.Jvm.dll => 0xef5e8475 => 22
	i32 4025784931, ; 178: System.Memory => 0xeff49a63 => 10
	i32 4101593132, ; 179: Xamarin.AndroidX.Emoji2 => 0xf479582c => 43
	i32 4105002889, ; 180: Mono.Security.dll => 0xf4ad5f89 => 91
	i32 4151237749, ; 181: System.Core => 0xf76edc75 => 7
	i32 4182413190, ; 182: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 53
	i32 4256097574, ; 183: Xamarin.AndroidX.Core.Core.Ktx => 0xfdaee526 => 35
	i32 4260525087, ; 184: System.Buffers => 0xfdf2741f => 6
	i32 4292120959 ; 185: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 53
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [186 x i32] [
	i32 51, i32 73, i32 29, i32 27, i32 47, i32 89, i32 33, i32 46, ; 0..7
	i32 19, i32 12, i32 48, i32 10, i32 32, i32 70, i32 45, i32 5, ; 8..15
	i32 8, i32 46, i32 55, i32 80, i32 3, i32 84, i32 38, i32 44, ; 16..23
	i32 11, i32 16, i32 67, i32 25, i32 90, i32 76, i32 74, i32 0, ; 24..31
	i32 83, i32 39, i32 82, i32 57, i32 73, i32 48, i32 61, i32 72, ; 32..39
	i32 24, i32 52, i32 75, i32 8, i32 65, i32 25, i32 30, i32 62, ; 40..47
	i32 77, i32 66, i32 76, i32 22, i32 41, i32 88, i32 61, i32 34, ; 48..55
	i32 14, i32 83, i32 23, i32 40, i32 87, i32 72, i32 54, i32 69, ; 56..63
	i32 44, i32 37, i32 86, i32 15, i32 63, i32 71, i32 33, i32 28, ; 64..71
	i32 7, i32 45, i32 3, i32 54, i32 75, i32 71, i32 70, i32 26, ; 72..79
	i32 56, i32 6, i32 52, i32 49, i32 15, i32 13, i32 9, i32 78, ; 80..87
	i32 86, i32 65, i32 55, i32 56, i32 59, i32 20, i32 43, i32 32, ; 88..95
	i32 1, i32 2, i32 81, i32 51, i32 16, i32 66, i32 78, i32 37, ; 96..103
	i32 42, i32 77, i32 63, i32 19, i32 23, i32 74, i32 68, i32 60, ; 104..111
	i32 34, i32 18, i32 60, i32 68, i32 64, i32 11, i32 85, i32 5, ; 112..119
	i32 69, i32 13, i32 21, i32 41, i32 50, i32 62, i32 47, i32 87, ; 120..127
	i32 92, i32 9, i32 79, i32 40, i32 91, i32 28, i32 92, i32 38, ; 128..135
	i32 79, i32 26, i32 58, i32 17, i32 36, i32 2, i32 59, i32 14, ; 136..143
	i32 88, i32 39, i32 0, i32 18, i32 1, i32 42, i32 4, i32 17, ; 144..151
	i32 80, i32 31, i32 90, i32 85, i32 57, i32 21, i32 49, i32 4, ; 152..159
	i32 89, i32 27, i32 31, i32 82, i32 35, i32 20, i32 29, i32 12, ; 160..167
	i32 64, i32 58, i32 36, i32 30, i32 84, i32 67, i32 81, i32 24, ; 168..175
	i32 50, i32 22, i32 10, i32 43, i32 91, i32 7, i32 53, i32 35, ; 176..183
	i32 6, i32 53 ; 184..185
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="none" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "stackrealign" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 4
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 4
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="none" "target-cpu"="i686" "target-features"="+cx8,+mmx,+sse,+sse2,+sse3,+ssse3,+x87" "tune-cpu"="generic" "stackrealign" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"NumRegisterParameters", i32 0}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}
