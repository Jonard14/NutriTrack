; ModuleID = 'obj\Debug\130\android\marshal_methods.armeabi-v7a.ll'
source_filename = "obj\Debug\130\android\marshal_methods.armeabi-v7a.ll"
target datalayout = "e-m:e-p:32:32-Fi8-i64:64-v128:64:128-a:0:32-n32-S64"
target triple = "armv7-unknown-linux-android"


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
@assembly_image_cache_hashes = local_unnamed_addr constant [188 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 50
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 72
	i32 134690465, ; 2: Xamarin.Kotlin.StdLib.Jdk7.dll => 0x80736a1 => 76
	i32 165246403, ; 3: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 28
	i32 209399409, ; 4: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 26
	i32 230216969, ; 5: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 46
	i32 232815796, ; 6: System.Web.Services => 0xde07cb4 => 90
	i32 261689757, ; 7: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 32
	i32 280482487, ; 8: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 45
	i32 318968648, ; 9: Xamarin.AndroidX.Activity.dll => 0x13031348 => 18
	i32 321597661, ; 10: System.Numerics => 0x132b30dd => 11
	i32 342366114, ; 11: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 47
	i32 385762202, ; 12: System.Memory.dll => 0x16fe439a => 10
	i32 441335492, ; 13: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 31
	i32 442521989, ; 14: Xamarin.Essentials => 0x1a605985 => 69
	i32 450948140, ; 15: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 44
	i32 465846621, ; 16: mscorlib => 0x1bc4415d => 5
	i32 469710990, ; 17: System.dll => 0x1bff388e => 8
	i32 476646585, ; 18: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 45
	i32 486930444, ; 19: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 54
	i32 526420162, ; 20: System.Transactions.dll => 0x1f6088c2 => 81
	i32 527452488, ; 21: Xamarin.Kotlin.StdLib.Jdk7 => 0x1f704948 => 76
	i32 548916678, ; 22: Microsoft.Bcl.AsyncInterfaces => 0x20b7cdc6 => 3
	i32 605376203, ; 23: System.IO.Compression.FileSystem => 0x24154ecb => 85
	i32 627609679, ; 24: Xamarin.AndroidX.CustomView => 0x2568904f => 37
	i32 639843206, ; 25: Xamarin.AndroidX.Emoji2.ViewsHelper.dll => 0x26233b86 => 43
	i32 662205335, ; 26: System.Text.Encodings.Web.dll => 0x27787397 => 15
	i32 663517072, ; 27: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 66
	i32 666292255, ; 28: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 24
	i32 690569205, ; 29: System.Xml.Linq.dll => 0x29293ff5 => 91
	i32 691348768, ; 30: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 78
	i32 700284507, ; 31: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 73
	i32 709365442, ; 32: App1 => 0x2a480ec2 => 0
	i32 720511267, ; 33: Xamarin.Kotlin.StdLib.Jdk8 => 0x2af22123 => 77
	i32 775507847, ; 34: System.IO.Compression => 0x2e394f87 => 84
	i32 790371945, ; 35: Xamarin.AndroidX.CustomView.PoolingContainer.dll => 0x2f1c1e69 => 38
	i32 809851609, ; 36: System.Drawing.Common.dll => 0x30455ad9 => 83
	i32 843511501, ; 37: Xamarin.AndroidX.Print => 0x3246f6cd => 56
	i32 928116545, ; 38: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 72
	i32 956575887, ; 39: Xamarin.Kotlin.StdLib.Jdk8.dll => 0x3904308f => 77
	i32 967690846, ; 40: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 47
	i32 1012816738, ; 41: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 60
	i32 1031528504, ; 42: Xamarin.Google.ErrorProne.Annotations.dll => 0x3d7be038 => 71
	i32 1035644815, ; 43: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 23
	i32 1052210849, ; 44: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 51
	i32 1084122840, ; 45: Xamarin.Kotlin.StdLib => 0x409e66d8 => 75
	i32 1098259244, ; 46: System => 0x41761b2c => 8
	i32 1175144683, ; 47: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 64
	i32 1204270330, ; 48: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 24
	i32 1246548578, ; 49: Xamarin.AndroidX.Collection.Jvm.dll => 0x4a4cd262 => 29
	i32 1264511973, ; 50: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0x4b5eebe5 => 61
	i32 1267360935, ; 51: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 65
	i32 1275534314, ; 52: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 78
	i32 1278448581, ; 53: Xamarin.AndroidX.Annotation.Jvm => 0x4c3393c5 => 21
	i32 1293217323, ; 54: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 40
	i32 1365406463, ; 55: System.ServiceModel.Internals.dll => 0x516272ff => 89
	i32 1376866003, ; 56: Xamarin.AndroidX.SavedState => 0x52114ed3 => 60
	i32 1406073936, ; 57: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 33
	i32 1411638395, ; 58: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 13
	i32 1462112819, ; 59: System.IO.Compression.dll => 0x57261233 => 84
	i32 1469204771, ; 60: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 22
	i32 1582372066, ; 61: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 39
	i32 1592978981, ; 62: System.Runtime.Serialization.dll => 0x5ef2ee25 => 88
	i32 1597949149, ; 63: Xamarin.Google.ErrorProne.Annotations => 0x5f3ec4dd => 71
	i32 1622152042, ; 64: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 53
	i32 1624863272, ; 65: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 68
	i32 1635184631, ; 66: Xamarin.AndroidX.Emoji2.ViewsHelper => 0x6176eff7 => 43
	i32 1636350590, ; 67: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 36
	i32 1639515021, ; 68: System.Net.Http.dll => 0x61b9038d => 87
	i32 1657153582, ; 69: System.Runtime => 0x62c6282e => 14
	i32 1658241508, ; 70: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 62
	i32 1658251792, ; 71: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 70
	i32 1670060433, ; 72: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 32
	i32 1698840827, ; 73: Xamarin.Kotlin.StdLib.Common => 0x654240fb => 74
	i32 1729485958, ; 74: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 27
	i32 1776026572, ; 75: System.Core.dll => 0x69dc03cc => 7
	i32 1788241197, ; 76: Xamarin.AndroidX.Fragment => 0x6a96652d => 44
	i32 1796167890, ; 77: Microsoft.Bcl.AsyncInterfaces.dll => 0x6b0f58d2 => 3
	i32 1808609942, ; 78: Xamarin.AndroidX.Loader => 0x6bcd3296 => 53
	i32 1813058853, ; 79: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 75
	i32 1813201214, ; 80: Xamarin.Google.Android.Material => 0x6c13413e => 70
	i32 1867746548, ; 81: Xamarin.Essentials.dll => 0x6f538cf4 => 69
	i32 1885316902, ; 82: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 25
	i32 1919157823, ; 83: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 55
	i32 1983156543, ; 84: Xamarin.Kotlin.StdLib.Common.dll => 0x7634913f => 74
	i32 2011961780, ; 85: System.Buffers.dll => 0x77ec19b4 => 6
	i32 2019465201, ; 86: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 51
	i32 2055257422, ; 87: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 48
	i32 2079903147, ; 88: System.Runtime.dll => 0x7bf8cdab => 14
	i32 2090596640, ; 89: System.Numerics.Vectors => 0x7c9bf920 => 12
	i32 2188064486, ; 90: System.Json.dll => 0x826b36e6 => 9
	i32 2201107256, ; 91: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 79
	i32 2201231467, ; 92: System.Net.Http => 0x8334206b => 87
	i32 2217644978, ; 93: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 64
	i32 2244775296, ; 94: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 54
	i32 2256548716, ; 95: Xamarin.AndroidX.MultiDex => 0x8680336c => 55
	i32 2279755925, ; 96: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 58
	i32 2315684594, ; 97: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 19
	i32 2403452196, ; 98: Xamarin.AndroidX.Emoji2.dll => 0x8f41c524 => 42
	i32 2465532216, ; 99: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 31
	i32 2471841756, ; 100: netstandard.dll => 0x93554fdc => 1
	i32 2475788418, ; 101: Java.Interop.dll => 0x93918882 => 2
	i32 2501346920, ; 102: System.Data.DataSetExtensions => 0x95178668 => 82
	i32 2505896520, ; 103: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 50
	i32 2570120770, ; 104: System.Text.Encodings.Web => 0x9930ee42 => 15
	i32 2581819634, ; 105: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 65
	i32 2605712449, ; 106: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 79
	i32 2620871830, ; 107: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 36
	i32 2624644809, ; 108: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 41
	i32 2701096212, ; 109: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 62
	i32 2732626843, ; 110: Xamarin.AndroidX.Activity => 0xa2e0939b => 18
	i32 2737747696, ; 111: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 22
	i32 2770495804, ; 112: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 73
	i32 2778768386, ; 113: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 67
	i32 2779977773, ; 114: Xamarin.AndroidX.ResourceInspection.Annotation.dll => 0xa5b3182d => 59
	i32 2810250172, ; 115: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 33
	i32 2819470561, ; 116: System.Xml.dll => 0xa80db4e1 => 17
	i32 2821294376, ; 117: Xamarin.AndroidX.ResourceInspection.Annotation => 0xa8298928 => 59
	i32 2853208004, ; 118: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 67
	i32 2855708567, ; 119: Xamarin.AndroidX.Transition => 0xaa36a797 => 63
	i32 2903344695, ; 120: System.ComponentModel.Composition => 0xad0d8637 => 86
	i32 2905242038, ; 121: mscorlib.dll => 0xad2a79b6 => 5
	i32 2916838712, ; 122: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 68
	i32 2919462931, ; 123: System.Numerics.Vectors.dll => 0xae037813 => 12
	i32 2921128767, ; 124: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 20
	i32 2978675010, ; 125: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 40
	i32 2996846495, ; 126: Xamarin.AndroidX.Lifecycle.Process.dll => 0xb2a03f9f => 49
	i32 3016983068, ; 127: Xamarin.AndroidX.Startup.StartupRuntime => 0xb3d3821c => 61
	i32 3024354802, ; 128: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 46
	i32 3111772706, ; 129: System.Runtime.Serialization => 0xb979e222 => 88
	i32 3124832203, ; 130: System.Threading.Tasks.Extensions => 0xba4127cb => 93
	i32 3201217166, ; 131: System.Json => 0xbeceb28e => 9
	i32 3204380047, ; 132: System.Data.dll => 0xbefef58f => 80
	i32 3211777861, ; 133: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 39
	i32 3247949154, ; 134: Mono.Security => 0xc197c562 => 92
	i32 3258312781, ; 135: Xamarin.AndroidX.CardView => 0xc235e84d => 27
	i32 3265893370, ; 136: System.Threading.Tasks.Extensions.dll => 0xc2a993fa => 93
	i32 3317135071, ; 137: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 37
	i32 3317144872, ; 138: System.Data => 0xc5b79d28 => 80
	i32 3340431453, ; 139: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 25
	i32 3345895724, ; 140: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xc76e512c => 57
	i32 3358260929, ; 141: System.Text.Json => 0xc82afec1 => 16
	i32 3362522851, ; 142: Xamarin.AndroidX.Core => 0xc86c06e3 => 35
	i32 3366347497, ; 143: Java.Interop => 0xc8a662e9 => 2
	i32 3374999561, ; 144: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 58
	i32 3395150330, ; 145: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 13
	i32 3404865022, ; 146: System.ServiceModel.Internals => 0xcaf21dfe => 89
	i32 3405233483, ; 147: Xamarin.AndroidX.CustomView.PoolingContainer => 0xcaf7bd4b => 38
	i32 3414721009, ; 148: App1.dll => 0xcb8881f1 => 0
	i32 3429136800, ; 149: System.Xml => 0xcc6479a0 => 17
	i32 3430777524, ; 150: netstandard => 0xcc7d82b4 => 1
	i32 3441283291, ; 151: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 41
	i32 3476120550, ; 152: Mono.Android => 0xcf3163e6 => 4
	i32 3485117614, ; 153: System.Text.Json.dll => 0xcfbaacae => 16
	i32 3486566296, ; 154: System.Transactions => 0xcfd0c798 => 81
	i32 3493954962, ; 155: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 30
	i32 3509114376, ; 156: System.Xml.Linq => 0xd128d608 => 91
	i32 3567349600, ; 157: System.ComponentModel.Composition.dll => 0xd4a16f60 => 86
	i32 3627220390, ; 158: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 56
	i32 3633644679, ; 159: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 20
	i32 3641597786, ; 160: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 48
	i32 3672681054, ; 161: Mono.Android.dll => 0xdae8aa5e => 4
	i32 3676310014, ; 162: System.Web.Services.dll => 0xdb2009fe => 90
	i32 3682565725, ; 163: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 26
	i32 3684561358, ; 164: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 30
	i32 3689375977, ; 165: System.Drawing.Common => 0xdbe768e9 => 83
	i32 3706696989, ; 166: Xamarin.AndroidX.Core.Core.Ktx.dll => 0xdcefb51d => 34
	i32 3718780102, ; 167: Xamarin.AndroidX.Annotation => 0xdda814c6 => 19
	i32 3786282454, ; 168: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 28
	i32 3829621856, ; 169: System.Numerics.dll => 0xe4436460 => 11
	i32 3885922214, ; 170: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 63
	i32 3888767677, ; 171: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0xe7c9e2bd => 57
	i32 3896760992, ; 172: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 35
	i32 3910130544, ; 173: Xamarin.AndroidX.Collection.Jvm => 0xe90fdb70 => 29
	i32 3920810846, ; 174: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 85
	i32 3921031405, ; 175: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 66
	i32 3945713374, ; 176: System.Data.DataSetExtensions.dll => 0xeb2ecede => 82
	i32 3955647286, ; 177: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 23
	i32 3959773229, ; 178: Xamarin.AndroidX.Lifecycle.Process => 0xec05582d => 49
	i32 4015948917, ; 179: Xamarin.AndroidX.Annotation.Jvm.dll => 0xef5e8475 => 21
	i32 4025784931, ; 180: System.Memory => 0xeff49a63 => 10
	i32 4101593132, ; 181: Xamarin.AndroidX.Emoji2 => 0xf479582c => 42
	i32 4105002889, ; 182: Mono.Security.dll => 0xf4ad5f89 => 92
	i32 4151237749, ; 183: System.Core => 0xf76edc75 => 7
	i32 4182413190, ; 184: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 52
	i32 4256097574, ; 185: Xamarin.AndroidX.Core.Core.Ktx => 0xfdaee526 => 34
	i32 4260525087, ; 186: System.Buffers => 0xfdf2741f => 6
	i32 4292120959 ; 187: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 52
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [188 x i32] [
	i32 50, i32 72, i32 76, i32 28, i32 26, i32 46, i32 90, i32 32, ; 0..7
	i32 45, i32 18, i32 11, i32 47, i32 10, i32 31, i32 69, i32 44, ; 8..15
	i32 5, i32 8, i32 45, i32 54, i32 81, i32 76, i32 3, i32 85, ; 16..23
	i32 37, i32 43, i32 15, i32 66, i32 24, i32 91, i32 78, i32 73, ; 24..31
	i32 0, i32 77, i32 84, i32 38, i32 83, i32 56, i32 72, i32 77, ; 32..39
	i32 47, i32 60, i32 71, i32 23, i32 51, i32 75, i32 8, i32 64, ; 40..47
	i32 24, i32 29, i32 61, i32 65, i32 78, i32 21, i32 40, i32 89, ; 48..55
	i32 60, i32 33, i32 13, i32 84, i32 22, i32 39, i32 88, i32 71, ; 56..63
	i32 53, i32 68, i32 43, i32 36, i32 87, i32 14, i32 62, i32 70, ; 64..71
	i32 32, i32 74, i32 27, i32 7, i32 44, i32 3, i32 53, i32 75, ; 72..79
	i32 70, i32 69, i32 25, i32 55, i32 74, i32 6, i32 51, i32 48, ; 80..87
	i32 14, i32 12, i32 9, i32 79, i32 87, i32 64, i32 54, i32 55, ; 88..95
	i32 58, i32 19, i32 42, i32 31, i32 1, i32 2, i32 82, i32 50, ; 96..103
	i32 15, i32 65, i32 79, i32 36, i32 41, i32 62, i32 18, i32 22, ; 104..111
	i32 73, i32 67, i32 59, i32 33, i32 17, i32 59, i32 67, i32 63, ; 112..119
	i32 86, i32 5, i32 68, i32 12, i32 20, i32 40, i32 49, i32 61, ; 120..127
	i32 46, i32 88, i32 93, i32 9, i32 80, i32 39, i32 92, i32 27, ; 128..135
	i32 93, i32 37, i32 80, i32 25, i32 57, i32 16, i32 35, i32 2, ; 136..143
	i32 58, i32 13, i32 89, i32 38, i32 0, i32 17, i32 1, i32 41, ; 144..151
	i32 4, i32 16, i32 81, i32 30, i32 91, i32 86, i32 56, i32 20, ; 152..159
	i32 48, i32 4, i32 90, i32 26, i32 30, i32 83, i32 34, i32 19, ; 160..167
	i32 28, i32 11, i32 63, i32 57, i32 35, i32 29, i32 85, i32 66, ; 168..175
	i32 82, i32 23, i32 49, i32 21, i32 10, i32 42, i32 92, i32 7, ; 176..183
	i32 52, i32 34, i32 6, i32 52 ; 184..187
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 4; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 4

; Function attributes: "frame-pointer"="all" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" uwtable willreturn writeonly
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


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="all" "target-cpu"="generic" "target-features"="+armv7-a,+d32,+dsp,+fp64,+neon,+thumb-mode,+vfp2,+vfp2sp,+vfp3,+vfp3d16,+vfp3d16sp,+vfp3sp,-aes,-fp-armv8,-fp-armv8d16,-fp-armv8d16sp,-fp-armv8sp,-fp16,-fp16fml,-fullfp16,-sha2,-vfp4,-vfp4d16,-vfp4d16sp,-vfp4sp" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2}
!llvm.ident = !{!3}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"min_enum_size", i32 4}
!3 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}
