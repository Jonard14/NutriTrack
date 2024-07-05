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
@assembly_image_cache_hashes = local_unnamed_addr constant [204 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 55
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 77
	i32 60940239, ; 2: I18N.Rare.dll => 0x3a1dfcf => 100
	i32 108920425, ; 3: Xamarin.AndroidX.AppCompat.Resources.dll => 0x67dfe69 => 28
	i32 165246403, ; 4: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 33
	i32 209399409, ; 5: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 31
	i32 230216969, ; 6: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 51
	i32 232815796, ; 7: System.Web.Services => 0xde07cb4 => 92
	i32 261689757, ; 8: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 37
	i32 280482487, ; 9: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 50
	i32 318968648, ; 10: Xamarin.AndroidX.Activity.dll => 0x13031348 => 22
	i32 321597661, ; 11: System.Numerics => 0x132b30dd => 15
	i32 337746723, ; 12: I18N.Other.dll => 0x14219b23 => 99
	i32 342366114, ; 13: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 52
	i32 385762202, ; 14: System.Memory.dll => 0x16fe439a => 13
	i32 441335492, ; 15: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 36
	i32 442521989, ; 16: Xamarin.Essentials => 0x1a605985 => 74
	i32 450948140, ; 17: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 49
	i32 465846621, ; 18: mscorlib => 0x1bc4415d => 5
	i32 469710990, ; 19: System.dll => 0x1bff388e => 10
	i32 476646585, ; 20: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 50
	i32 486930444, ; 21: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 59
	i32 526420162, ; 22: System.Transactions.dll => 0x1f6088c2 => 91
	i32 548916678, ; 23: Microsoft.Bcl.AsyncInterfaces => 0x20b7cdc6 => 3
	i32 605376203, ; 24: System.IO.Compression.FileSystem => 0x24154ecb => 86
	i32 627609679, ; 25: Xamarin.AndroidX.CustomView => 0x2568904f => 42
	i32 639843206, ; 26: Xamarin.AndroidX.Emoji2.ViewsHelper.dll => 0x26233b86 => 48
	i32 643868501, ; 27: System.Net => 0x2660a755 => 14
	i32 662205335, ; 28: System.Text.Encodings.Web.dll => 0x27787397 => 19
	i32 663517072, ; 29: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 71
	i32 666292255, ; 30: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 29
	i32 690569205, ; 31: System.Xml.Linq.dll => 0x29293ff5 => 93
	i32 691348768, ; 32: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 80
	i32 700284507, ; 33: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 78
	i32 709365442, ; 34: App1 => 0x2a480ec2 => 0
	i32 725851412, ; 35: I18N.West.dll => 0x2b439d14 => 101
	i32 775507847, ; 36: System.IO.Compression => 0x2e394f87 => 85
	i32 790371945, ; 37: Xamarin.AndroidX.CustomView.PoolingContainer.dll => 0x2f1c1e69 => 43
	i32 809851609, ; 38: System.Drawing.Common.dll => 0x30455ad9 => 84
	i32 843511501, ; 39: Xamarin.AndroidX.Print => 0x3246f6cd => 61
	i32 928116545, ; 40: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 77
	i32 945617440, ; 41: I18N.CJK => 0x385cfa20 => 97
	i32 963428712, ; 42: Xamarin.AndroidX.AppCompat.Resources => 0x396cc168 => 28
	i32 967690846, ; 43: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 52
	i32 1012816738, ; 44: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 65
	i32 1031528504, ; 45: Xamarin.Google.ErrorProne.Annotations.dll => 0x3d7be038 => 76
	i32 1035644815, ; 46: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 27
	i32 1052210849, ; 47: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 56
	i32 1084122840, ; 48: Xamarin.Kotlin.StdLib => 0x409e66d8 => 79
	i32 1098259244, ; 49: System => 0x41761b2c => 10
	i32 1175144683, ; 50: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 69
	i32 1204270330, ; 51: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 29
	i32 1246548578, ; 52: Xamarin.AndroidX.Collection.Jvm.dll => 0x4a4cd262 => 34
	i32 1264511973, ; 53: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0x4b5eebe5 => 66
	i32 1264890200, ; 54: Xamarin.KotlinX.Coroutines.Core.dll => 0x4b64b158 => 81
	i32 1267360935, ; 55: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 70
	i32 1275534314, ; 56: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 80
	i32 1278448581, ; 57: Xamarin.AndroidX.Annotation.Jvm => 0x4c3393c5 => 25
	i32 1290254209, ; 58: I18N.Rare => 0x4ce7b781 => 100
	i32 1293217323, ; 59: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 45
	i32 1365406463, ; 60: System.ServiceModel.Internals.dll => 0x516272ff => 90
	i32 1368767823, ; 61: I18N.Other => 0x5195bd4f => 99
	i32 1376866003, ; 62: Xamarin.AndroidX.SavedState => 0x52114ed3 => 65
	i32 1406073936, ; 63: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 38
	i32 1411638395, ; 64: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 17
	i32 1462112819, ; 65: System.IO.Compression.dll => 0x57261233 => 85
	i32 1469204771, ; 66: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 26
	i32 1582372066, ; 67: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 44
	i32 1592978981, ; 68: System.Runtime.Serialization.dll => 0x5ef2ee25 => 89
	i32 1597949149, ; 69: Xamarin.Google.ErrorProne.Annotations => 0x5f3ec4dd => 76
	i32 1599450359, ; 70: I18N.MidEast.dll => 0x5f55acf7 => 98
	i32 1622152042, ; 71: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 58
	i32 1624863272, ; 72: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 73
	i32 1635184631, ; 73: Xamarin.AndroidX.Emoji2.ViewsHelper => 0x6176eff7 => 48
	i32 1636350590, ; 74: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 41
	i32 1639515021, ; 75: System.Net.Http.dll => 0x61b9038d => 88
	i32 1657153582, ; 76: System.Runtime => 0x62c6282e => 18
	i32 1658241508, ; 77: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 67
	i32 1658251792, ; 78: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 75
	i32 1670060433, ; 79: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 37
	i32 1729485958, ; 80: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 32
	i32 1746115085, ; 81: System.IO.Pipelines.dll => 0x68139a0d => 11
	i32 1776026572, ; 82: System.Core.dll => 0x69dc03cc => 7
	i32 1788241197, ; 83: Xamarin.AndroidX.Fragment => 0x6a96652d => 49
	i32 1796167890, ; 84: Microsoft.Bcl.AsyncInterfaces.dll => 0x6b0f58d2 => 3
	i32 1808609942, ; 85: Xamarin.AndroidX.Loader => 0x6bcd3296 => 58
	i32 1813058853, ; 86: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 79
	i32 1813201214, ; 87: Xamarin.Google.Android.Material => 0x6c13413e => 75
	i32 1867746548, ; 88: Xamarin.Essentials.dll => 0x6f538cf4 => 74
	i32 1885316902, ; 89: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 30
	i32 1919157823, ; 90: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 60
	i32 2011961780, ; 91: System.Buffers.dll => 0x77ec19b4 => 6
	i32 2019465201, ; 92: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 56
	i32 2055257422, ; 93: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 53
	i32 2067863569, ; 94: I18N.dll => 0x7b411811 => 96
	i32 2079903147, ; 95: System.Runtime.dll => 0x7bf8cdab => 18
	i32 2090596640, ; 96: System.Numerics.Vectors => 0x7c9bf920 => 16
	i32 2142278582, ; 97: System.Data.OleDb.dll => 0x7fb093b6 => 9
	i32 2188064486, ; 98: System.Json.dll => 0x826b36e6 => 12
	i32 2201107256, ; 99: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 82
	i32 2201231467, ; 100: System.Net.Http => 0x8334206b => 88
	i32 2217644978, ; 101: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 69
	i32 2244775296, ; 102: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 59
	i32 2256548716, ; 103: Xamarin.AndroidX.MultiDex => 0x8680336c => 60
	i32 2279755925, ; 104: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 63
	i32 2315684594, ; 105: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 23
	i32 2403452196, ; 106: Xamarin.AndroidX.Emoji2.dll => 0x8f41c524 => 47
	i32 2465532216, ; 107: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 36
	i32 2471841756, ; 108: netstandard.dll => 0x93554fdc => 1
	i32 2475788418, ; 109: Java.Interop.dll => 0x93918882 => 2
	i32 2501346920, ; 110: System.Data.DataSetExtensions => 0x95178668 => 83
	i32 2505896520, ; 111: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 55
	i32 2521135010, ; 112: I18N.CJK.dll => 0x964577a2 => 97
	i32 2570120770, ; 113: System.Text.Encodings.Web => 0x9930ee42 => 19
	i32 2581274016, ; 114: I18N.West => 0x99db1da0 => 101
	i32 2581819634, ; 115: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 70
	i32 2605712449, ; 116: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 82
	i32 2620871830, ; 117: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 41
	i32 2624644809, ; 118: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 46
	i32 2671474046, ; 119: Xamarin.KotlinX.Coroutines.Core => 0x9f3b757e => 81
	i32 2701096212, ; 120: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 67
	i32 2732626843, ; 121: Xamarin.AndroidX.Activity => 0xa2e0939b => 22
	i32 2736590120, ; 122: System.Data.OleDb => 0xa31d0d28 => 9
	i32 2737747696, ; 123: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 26
	i32 2770495804, ; 124: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 78
	i32 2778768386, ; 125: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 72
	i32 2779977773, ; 126: Xamarin.AndroidX.ResourceInspection.Annotation.dll => 0xa5b3182d => 64
	i32 2810250172, ; 127: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 38
	i32 2819470561, ; 128: System.Xml.dll => 0xa80db4e1 => 21
	i32 2821294376, ; 129: Xamarin.AndroidX.ResourceInspection.Annotation => 0xa8298928 => 64
	i32 2853208004, ; 130: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 72
	i32 2855708567, ; 131: Xamarin.AndroidX.Transition => 0xaa36a797 => 68
	i32 2887636118, ; 132: System.Net.dll => 0xac1dd496 => 14
	i32 2903344695, ; 133: System.ComponentModel.Composition => 0xad0d8637 => 87
	i32 2905242038, ; 134: mscorlib.dll => 0xad2a79b6 => 5
	i32 2916838712, ; 135: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 73
	i32 2919462931, ; 136: System.Numerics.Vectors.dll => 0xae037813 => 16
	i32 2921128767, ; 137: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 24
	i32 2978675010, ; 138: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 45
	i32 2996846495, ; 139: Xamarin.AndroidX.Lifecycle.Process.dll => 0xb2a03f9f => 54
	i32 3016983068, ; 140: Xamarin.AndroidX.Startup.StartupRuntime => 0xb3d3821c => 66
	i32 3024354802, ; 141: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 51
	i32 3111772706, ; 142: System.Runtime.Serialization => 0xb979e222 => 89
	i32 3124832203, ; 143: System.Threading.Tasks.Extensions => 0xba4127cb => 95
	i32 3201217166, ; 144: System.Json => 0xbeceb28e => 12
	i32 3204380047, ; 145: System.Data.dll => 0xbefef58f => 8
	i32 3211777861, ; 146: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 44
	i32 3247949154, ; 147: Mono.Security => 0xc197c562 => 94
	i32 3258312781, ; 148: Xamarin.AndroidX.CardView => 0xc235e84d => 32
	i32 3265893370, ; 149: System.Threading.Tasks.Extensions.dll => 0xc2a993fa => 95
	i32 3317135071, ; 150: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 42
	i32 3317144872, ; 151: System.Data => 0xc5b79d28 => 8
	i32 3340431453, ; 152: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 30
	i32 3345895724, ; 153: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xc76e512c => 62
	i32 3358260929, ; 154: System.Text.Json => 0xc82afec1 => 20
	i32 3362522851, ; 155: Xamarin.AndroidX.Core => 0xc86c06e3 => 40
	i32 3366347497, ; 156: Java.Interop => 0xc8a662e9 => 2
	i32 3374999561, ; 157: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 63
	i32 3395150330, ; 158: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 17
	i32 3404865022, ; 159: System.ServiceModel.Internals => 0xcaf21dfe => 90
	i32 3405233483, ; 160: Xamarin.AndroidX.CustomView.PoolingContainer => 0xcaf7bd4b => 43
	i32 3414721009, ; 161: App1.dll => 0xcb8881f1 => 0
	i32 3429136800, ; 162: System.Xml => 0xcc6479a0 => 21
	i32 3430777524, ; 163: netstandard => 0xcc7d82b4 => 1
	i32 3441283291, ; 164: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 46
	i32 3476120550, ; 165: Mono.Android => 0xcf3163e6 => 4
	i32 3485117614, ; 166: System.Text.Json.dll => 0xcfbaacae => 20
	i32 3486566296, ; 167: System.Transactions => 0xcfd0c798 => 91
	i32 3493954962, ; 168: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 35
	i32 3509114376, ; 169: System.Xml.Linq => 0xd128d608 => 93
	i32 3540208256, ; 170: I18N.MidEast => 0xd3034a80 => 98
	i32 3567349600, ; 171: System.ComponentModel.Composition.dll => 0xd4a16f60 => 87
	i32 3579244613, ; 172: I18N => 0xd556f045 => 96
	i32 3627220390, ; 173: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 61
	i32 3633644679, ; 174: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 24
	i32 3641597786, ; 175: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 53
	i32 3672681054, ; 176: Mono.Android.dll => 0xdae8aa5e => 4
	i32 3676310014, ; 177: System.Web.Services.dll => 0xdb2009fe => 92
	i32 3682565725, ; 178: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 31
	i32 3684561358, ; 179: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 35
	i32 3689375977, ; 180: System.Drawing.Common => 0xdbe768e9 => 84
	i32 3706696989, ; 181: Xamarin.AndroidX.Core.Core.Ktx.dll => 0xdcefb51d => 39
	i32 3718780102, ; 182: Xamarin.AndroidX.Annotation => 0xdda814c6 => 23
	i32 3786282454, ; 183: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 33
	i32 3829621856, ; 184: System.Numerics.dll => 0xe4436460 => 15
	i32 3885922214, ; 185: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 68
	i32 3888767677, ; 186: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0xe7c9e2bd => 62
	i32 3896760992, ; 187: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 40
	i32 3910130544, ; 188: Xamarin.AndroidX.Collection.Jvm => 0xe90fdb70 => 34
	i32 3920810846, ; 189: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 86
	i32 3921031405, ; 190: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 71
	i32 3945713374, ; 191: System.Data.DataSetExtensions.dll => 0xeb2ecede => 83
	i32 3955647286, ; 192: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 27
	i32 3959773229, ; 193: Xamarin.AndroidX.Lifecycle.Process => 0xec05582d => 54
	i32 4015948917, ; 194: Xamarin.AndroidX.Annotation.Jvm.dll => 0xef5e8475 => 25
	i32 4023392905, ; 195: System.IO.Pipelines => 0xefd01a89 => 11
	i32 4025784931, ; 196: System.Memory => 0xeff49a63 => 13
	i32 4101593132, ; 197: Xamarin.AndroidX.Emoji2 => 0xf479582c => 47
	i32 4105002889, ; 198: Mono.Security.dll => 0xf4ad5f89 => 94
	i32 4151237749, ; 199: System.Core => 0xf76edc75 => 7
	i32 4182413190, ; 200: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 57
	i32 4256097574, ; 201: Xamarin.AndroidX.Core.Core.Ktx => 0xfdaee526 => 39
	i32 4260525087, ; 202: System.Buffers => 0xfdf2741f => 6
	i32 4292120959 ; 203: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 57
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [204 x i32] [
	i32 55, i32 77, i32 100, i32 28, i32 33, i32 31, i32 51, i32 92, ; 0..7
	i32 37, i32 50, i32 22, i32 15, i32 99, i32 52, i32 13, i32 36, ; 8..15
	i32 74, i32 49, i32 5, i32 10, i32 50, i32 59, i32 91, i32 3, ; 16..23
	i32 86, i32 42, i32 48, i32 14, i32 19, i32 71, i32 29, i32 93, ; 24..31
	i32 80, i32 78, i32 0, i32 101, i32 85, i32 43, i32 84, i32 61, ; 32..39
	i32 77, i32 97, i32 28, i32 52, i32 65, i32 76, i32 27, i32 56, ; 40..47
	i32 79, i32 10, i32 69, i32 29, i32 34, i32 66, i32 81, i32 70, ; 48..55
	i32 80, i32 25, i32 100, i32 45, i32 90, i32 99, i32 65, i32 38, ; 56..63
	i32 17, i32 85, i32 26, i32 44, i32 89, i32 76, i32 98, i32 58, ; 64..71
	i32 73, i32 48, i32 41, i32 88, i32 18, i32 67, i32 75, i32 37, ; 72..79
	i32 32, i32 11, i32 7, i32 49, i32 3, i32 58, i32 79, i32 75, ; 80..87
	i32 74, i32 30, i32 60, i32 6, i32 56, i32 53, i32 96, i32 18, ; 88..95
	i32 16, i32 9, i32 12, i32 82, i32 88, i32 69, i32 59, i32 60, ; 96..103
	i32 63, i32 23, i32 47, i32 36, i32 1, i32 2, i32 83, i32 55, ; 104..111
	i32 97, i32 19, i32 101, i32 70, i32 82, i32 41, i32 46, i32 81, ; 112..119
	i32 67, i32 22, i32 9, i32 26, i32 78, i32 72, i32 64, i32 38, ; 120..127
	i32 21, i32 64, i32 72, i32 68, i32 14, i32 87, i32 5, i32 73, ; 128..135
	i32 16, i32 24, i32 45, i32 54, i32 66, i32 51, i32 89, i32 95, ; 136..143
	i32 12, i32 8, i32 44, i32 94, i32 32, i32 95, i32 42, i32 8, ; 144..151
	i32 30, i32 62, i32 20, i32 40, i32 2, i32 63, i32 17, i32 90, ; 152..159
	i32 43, i32 0, i32 21, i32 1, i32 46, i32 4, i32 20, i32 91, ; 160..167
	i32 35, i32 93, i32 98, i32 87, i32 96, i32 61, i32 24, i32 53, ; 168..175
	i32 4, i32 92, i32 31, i32 35, i32 84, i32 39, i32 23, i32 33, ; 176..183
	i32 15, i32 68, i32 62, i32 40, i32 34, i32 86, i32 71, i32 83, ; 184..191
	i32 27, i32 54, i32 25, i32 11, i32 13, i32 47, i32 94, i32 7, ; 192..199
	i32 57, i32 39, i32 6, i32 57 ; 200..203
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
