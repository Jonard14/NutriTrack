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
@assembly_image_cache_hashes = local_unnamed_addr constant [214 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 60
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 82
	i32 60940239, ; 2: I18N.Rare.dll => 0x3a1dfcf => 105
	i32 108920425, ; 3: Xamarin.AndroidX.AppCompat.Resources.dll => 0x67dfe69 => 33
	i32 165246403, ; 4: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 38
	i32 209399409, ; 5: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 36
	i32 230216969, ; 6: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 56
	i32 232815796, ; 7: System.Web.Services => 0xde07cb4 => 97
	i32 261689757, ; 8: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 42
	i32 280482487, ; 9: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 55
	i32 318968648, ; 10: Xamarin.AndroidX.Activity.dll => 0x13031348 => 27
	i32 321597661, ; 11: System.Numerics => 0x132b30dd => 19
	i32 337746723, ; 12: I18N.Other.dll => 0x14219b23 => 104
	i32 342366114, ; 13: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 57
	i32 385762202, ; 14: System.Memory.dll => 0x16fe439a => 17
	i32 441335492, ; 15: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 41
	i32 442521989, ; 16: Xamarin.Essentials => 0x1a605985 => 79
	i32 450948140, ; 17: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 54
	i32 465846621, ; 18: mscorlib => 0x1bc4415d => 8
	i32 469710990, ; 19: System.dll => 0x1bff388e => 13
	i32 476646585, ; 20: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 55
	i32 486930444, ; 21: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 64
	i32 526420162, ; 22: System.Transactions.dll => 0x1f6088c2 => 96
	i32 548916678, ; 23: Microsoft.Bcl.AsyncInterfaces => 0x20b7cdc6 => 5
	i32 586578074, ; 24: MimeKit => 0x22f6789a => 6
	i32 605376203, ; 25: System.IO.Compression.FileSystem => 0x24154ecb => 91
	i32 627609679, ; 26: Xamarin.AndroidX.CustomView => 0x2568904f => 47
	i32 639843206, ; 27: Xamarin.AndroidX.Emoji2.ViewsHelper.dll => 0x26233b86 => 53
	i32 643868501, ; 28: System.Net => 0x2660a755 => 18
	i32 662205335, ; 29: System.Text.Encodings.Web.dll => 0x27787397 => 24
	i32 663517072, ; 30: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 76
	i32 666292255, ; 31: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 34
	i32 690569205, ; 32: System.Xml.Linq.dll => 0x29293ff5 => 98
	i32 691348768, ; 33: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 85
	i32 700284507, ; 34: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 83
	i32 709152836, ; 35: System.Security.Cryptography.Pkcs.dll => 0x2a44d044 => 23
	i32 709365442, ; 36: App1 => 0x2a480ec2 => 0
	i32 725851412, ; 37: I18N.West.dll => 0x2b439d14 => 106
	i32 775507847, ; 38: System.IO.Compression => 0x2e394f87 => 90
	i32 790371945, ; 39: Xamarin.AndroidX.CustomView.PoolingContainer.dll => 0x2f1c1e69 => 48
	i32 809851609, ; 40: System.Drawing.Common.dll => 0x30455ad9 => 89
	i32 843511501, ; 41: Xamarin.AndroidX.Print => 0x3246f6cd => 66
	i32 928116545, ; 42: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 82
	i32 945617440, ; 43: I18N.CJK => 0x385cfa20 => 102
	i32 963428712, ; 44: Xamarin.AndroidX.AppCompat.Resources => 0x396cc168 => 33
	i32 967690846, ; 45: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 57
	i32 1012816738, ; 46: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 70
	i32 1031528504, ; 47: Xamarin.Google.ErrorProne.Annotations.dll => 0x3d7be038 => 81
	i32 1035644815, ; 48: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 32
	i32 1052210849, ; 49: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 61
	i32 1084122840, ; 50: Xamarin.Kotlin.StdLib => 0x409e66d8 => 84
	i32 1098259244, ; 51: System => 0x41761b2c => 13
	i32 1175144683, ; 52: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 74
	i32 1204270330, ; 53: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 34
	i32 1246548578, ; 54: Xamarin.AndroidX.Collection.Jvm.dll => 0x4a4cd262 => 39
	i32 1264511973, ; 55: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0x4b5eebe5 => 71
	i32 1264890200, ; 56: Xamarin.KotlinX.Coroutines.Core.dll => 0x4b64b158 => 86
	i32 1267360935, ; 57: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 75
	i32 1275534314, ; 58: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 85
	i32 1278448581, ; 59: Xamarin.AndroidX.Annotation.Jvm => 0x4c3393c5 => 30
	i32 1290254209, ; 60: I18N.Rare => 0x4ce7b781 => 105
	i32 1293217323, ; 61: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 50
	i32 1365406463, ; 62: System.ServiceModel.Internals.dll => 0x516272ff => 95
	i32 1368767823, ; 63: I18N.Other => 0x5195bd4f => 104
	i32 1376866003, ; 64: Xamarin.AndroidX.SavedState => 0x52114ed3 => 70
	i32 1406073936, ; 65: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 43
	i32 1411638395, ; 66: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 21
	i32 1452070440, ; 67: System.Formats.Asn1.dll => 0x568cd628 => 14
	i32 1462112819, ; 68: System.IO.Compression.dll => 0x57261233 => 90
	i32 1469204771, ; 69: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 31
	i32 1582372066, ; 70: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 49
	i32 1592978981, ; 71: System.Runtime.Serialization.dll => 0x5ef2ee25 => 94
	i32 1597949149, ; 72: Xamarin.Google.ErrorProne.Annotations => 0x5f3ec4dd => 81
	i32 1599450359, ; 73: I18N.MidEast.dll => 0x5f55acf7 => 103
	i32 1622152042, ; 74: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 63
	i32 1624863272, ; 75: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 78
	i32 1635184631, ; 76: Xamarin.AndroidX.Emoji2.ViewsHelper => 0x6176eff7 => 53
	i32 1636350590, ; 77: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 46
	i32 1639515021, ; 78: System.Net.Http.dll => 0x61b9038d => 93
	i32 1657153582, ; 79: System.Runtime => 0x62c6282e => 22
	i32 1658241508, ; 80: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 72
	i32 1658251792, ; 81: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 80
	i32 1670060433, ; 82: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 42
	i32 1729485958, ; 83: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 37
	i32 1733338956, ; 84: MailKit => 0x6750a74c => 4
	i32 1746115085, ; 85: System.IO.Pipelines.dll => 0x68139a0d => 15
	i32 1776026572, ; 86: System.Core.dll => 0x69dc03cc => 10
	i32 1788241197, ; 87: Xamarin.AndroidX.Fragment => 0x6a96652d => 54
	i32 1796167890, ; 88: Microsoft.Bcl.AsyncInterfaces.dll => 0x6b0f58d2 => 5
	i32 1808609942, ; 89: Xamarin.AndroidX.Loader => 0x6bcd3296 => 63
	i32 1813058853, ; 90: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 84
	i32 1813201214, ; 91: Xamarin.Google.Android.Material => 0x6c13413e => 80
	i32 1867746548, ; 92: Xamarin.Essentials.dll => 0x6f538cf4 => 79
	i32 1885316902, ; 93: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 35
	i32 1919157823, ; 94: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 65
	i32 2011961780, ; 95: System.Buffers.dll => 0x77ec19b4 => 9
	i32 2019465201, ; 96: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 61
	i32 2026931361, ; 97: MailKit.dll => 0x78d084a1 => 4
	i32 2055257422, ; 98: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 58
	i32 2067863569, ; 99: I18N.dll => 0x7b411811 => 101
	i32 2079903147, ; 100: System.Runtime.dll => 0x7bf8cdab => 22
	i32 2090596640, ; 101: System.Numerics.Vectors => 0x7c9bf920 => 20
	i32 2142278582, ; 102: System.Data.OleDb.dll => 0x7fb093b6 => 12
	i32 2188064486, ; 103: System.Json.dll => 0x826b36e6 => 16
	i32 2201107256, ; 104: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 87
	i32 2201231467, ; 105: System.Net.Http => 0x8334206b => 93
	i32 2217644978, ; 106: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 74
	i32 2244775296, ; 107: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 64
	i32 2256548716, ; 108: Xamarin.AndroidX.MultiDex => 0x8680336c => 65
	i32 2279755925, ; 109: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 68
	i32 2315684594, ; 110: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 28
	i32 2403452196, ; 111: Xamarin.AndroidX.Emoji2.dll => 0x8f41c524 => 52
	i32 2465532216, ; 112: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 41
	i32 2471841756, ; 113: netstandard.dll => 0x93554fdc => 1
	i32 2475788418, ; 114: Java.Interop.dll => 0x93918882 => 3
	i32 2498657740, ; 115: BouncyCastle.Cryptography.dll => 0x94ee7dcc => 2
	i32 2501346920, ; 116: System.Data.DataSetExtensions => 0x95178668 => 88
	i32 2505896520, ; 117: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 60
	i32 2521135010, ; 118: I18N.CJK.dll => 0x964577a2 => 102
	i32 2570120770, ; 119: System.Text.Encodings.Web => 0x9930ee42 => 24
	i32 2581274016, ; 120: I18N.West => 0x99db1da0 => 106
	i32 2581819634, ; 121: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 75
	i32 2605712449, ; 122: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 87
	i32 2620871830, ; 123: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 46
	i32 2624644809, ; 124: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 51
	i32 2671474046, ; 125: Xamarin.KotlinX.Coroutines.Core => 0x9f3b757e => 86
	i32 2701096212, ; 126: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 72
	i32 2732626843, ; 127: Xamarin.AndroidX.Activity => 0xa2e0939b => 27
	i32 2736590120, ; 128: System.Data.OleDb => 0xa31d0d28 => 12
	i32 2737747696, ; 129: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 31
	i32 2770495804, ; 130: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 83
	i32 2778768386, ; 131: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 77
	i32 2779977773, ; 132: Xamarin.AndroidX.ResourceInspection.Annotation.dll => 0xa5b3182d => 69
	i32 2810250172, ; 133: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 43
	i32 2819470561, ; 134: System.Xml.dll => 0xa80db4e1 => 26
	i32 2821294376, ; 135: Xamarin.AndroidX.ResourceInspection.Annotation => 0xa8298928 => 69
	i32 2853208004, ; 136: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 77
	i32 2855708567, ; 137: Xamarin.AndroidX.Transition => 0xaa36a797 => 73
	i32 2887636118, ; 138: System.Net.dll => 0xac1dd496 => 18
	i32 2903344695, ; 139: System.ComponentModel.Composition => 0xad0d8637 => 92
	i32 2905242038, ; 140: mscorlib.dll => 0xad2a79b6 => 8
	i32 2916838712, ; 141: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 78
	i32 2919462931, ; 142: System.Numerics.Vectors.dll => 0xae037813 => 20
	i32 2921128767, ; 143: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 29
	i32 2978675010, ; 144: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 50
	i32 2996846495, ; 145: Xamarin.AndroidX.Lifecycle.Process.dll => 0xb2a03f9f => 59
	i32 3016983068, ; 146: Xamarin.AndroidX.Startup.StartupRuntime => 0xb3d3821c => 71
	i32 3024354802, ; 147: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 56
	i32 3103600923, ; 148: System.Formats.Asn1 => 0xb8fd311b => 14
	i32 3111772706, ; 149: System.Runtime.Serialization => 0xb979e222 => 94
	i32 3124832203, ; 150: System.Threading.Tasks.Extensions => 0xba4127cb => 100
	i32 3171180504, ; 151: MimeKit.dll => 0xbd045fd8 => 6
	i32 3201217166, ; 152: System.Json => 0xbeceb28e => 16
	i32 3204380047, ; 153: System.Data.dll => 0xbefef58f => 11
	i32 3211777861, ; 154: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 49
	i32 3247949154, ; 155: Mono.Security => 0xc197c562 => 99
	i32 3258312781, ; 156: Xamarin.AndroidX.CardView => 0xc235e84d => 37
	i32 3265893370, ; 157: System.Threading.Tasks.Extensions.dll => 0xc2a993fa => 100
	i32 3317135071, ; 158: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 47
	i32 3317144872, ; 159: System.Data => 0xc5b79d28 => 11
	i32 3340431453, ; 160: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 35
	i32 3345895724, ; 161: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xc76e512c => 67
	i32 3358260929, ; 162: System.Text.Json => 0xc82afec1 => 25
	i32 3362522851, ; 163: Xamarin.AndroidX.Core => 0xc86c06e3 => 45
	i32 3366347497, ; 164: Java.Interop => 0xc8a662e9 => 3
	i32 3374999561, ; 165: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 68
	i32 3395150330, ; 166: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 21
	i32 3404865022, ; 167: System.ServiceModel.Internals => 0xcaf21dfe => 95
	i32 3405233483, ; 168: Xamarin.AndroidX.CustomView.PoolingContainer => 0xcaf7bd4b => 48
	i32 3414721009, ; 169: App1.dll => 0xcb8881f1 => 0
	i32 3429136800, ; 170: System.Xml => 0xcc6479a0 => 26
	i32 3430777524, ; 171: netstandard => 0xcc7d82b4 => 1
	i32 3441283291, ; 172: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 51
	i32 3476120550, ; 173: Mono.Android => 0xcf3163e6 => 7
	i32 3485117614, ; 174: System.Text.Json.dll => 0xcfbaacae => 25
	i32 3486566296, ; 175: System.Transactions => 0xcfd0c798 => 96
	i32 3493954962, ; 176: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 40
	i32 3509114376, ; 177: System.Xml.Linq => 0xd128d608 => 98
	i32 3540208256, ; 178: I18N.MidEast => 0xd3034a80 => 103
	i32 3567349600, ; 179: System.ComponentModel.Composition.dll => 0xd4a16f60 => 92
	i32 3579244613, ; 180: I18N => 0xd556f045 => 101
	i32 3605570793, ; 181: BouncyCastle.Cryptography => 0xd6e8a4e9 => 2
	i32 3627220390, ; 182: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 66
	i32 3633644679, ; 183: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 29
	i32 3641597786, ; 184: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 58
	i32 3672681054, ; 185: Mono.Android.dll => 0xdae8aa5e => 7
	i32 3676310014, ; 186: System.Web.Services.dll => 0xdb2009fe => 97
	i32 3682565725, ; 187: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 36
	i32 3684561358, ; 188: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 40
	i32 3689375977, ; 189: System.Drawing.Common => 0xdbe768e9 => 89
	i32 3706696989, ; 190: Xamarin.AndroidX.Core.Core.Ktx.dll => 0xdcefb51d => 44
	i32 3718780102, ; 191: Xamarin.AndroidX.Annotation => 0xdda814c6 => 28
	i32 3786282454, ; 192: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 38
	i32 3807198597, ; 193: System.Security.Cryptography.Pkcs => 0xe2ed3d85 => 23
	i32 3829621856, ; 194: System.Numerics.dll => 0xe4436460 => 19
	i32 3885922214, ; 195: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 73
	i32 3888767677, ; 196: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0xe7c9e2bd => 67
	i32 3896760992, ; 197: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 45
	i32 3910130544, ; 198: Xamarin.AndroidX.Collection.Jvm => 0xe90fdb70 => 39
	i32 3920810846, ; 199: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 91
	i32 3921031405, ; 200: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 76
	i32 3945713374, ; 201: System.Data.DataSetExtensions.dll => 0xeb2ecede => 88
	i32 3955647286, ; 202: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 32
	i32 3959773229, ; 203: Xamarin.AndroidX.Lifecycle.Process => 0xec05582d => 59
	i32 4015948917, ; 204: Xamarin.AndroidX.Annotation.Jvm.dll => 0xef5e8475 => 30
	i32 4023392905, ; 205: System.IO.Pipelines => 0xefd01a89 => 15
	i32 4025784931, ; 206: System.Memory => 0xeff49a63 => 17
	i32 4101593132, ; 207: Xamarin.AndroidX.Emoji2 => 0xf479582c => 52
	i32 4105002889, ; 208: Mono.Security.dll => 0xf4ad5f89 => 99
	i32 4151237749, ; 209: System.Core => 0xf76edc75 => 10
	i32 4182413190, ; 210: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 62
	i32 4256097574, ; 211: Xamarin.AndroidX.Core.Core.Ktx => 0xfdaee526 => 44
	i32 4260525087, ; 212: System.Buffers => 0xfdf2741f => 9
	i32 4292120959 ; 213: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 62
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [214 x i32] [
	i32 60, i32 82, i32 105, i32 33, i32 38, i32 36, i32 56, i32 97, ; 0..7
	i32 42, i32 55, i32 27, i32 19, i32 104, i32 57, i32 17, i32 41, ; 8..15
	i32 79, i32 54, i32 8, i32 13, i32 55, i32 64, i32 96, i32 5, ; 16..23
	i32 6, i32 91, i32 47, i32 53, i32 18, i32 24, i32 76, i32 34, ; 24..31
	i32 98, i32 85, i32 83, i32 23, i32 0, i32 106, i32 90, i32 48, ; 32..39
	i32 89, i32 66, i32 82, i32 102, i32 33, i32 57, i32 70, i32 81, ; 40..47
	i32 32, i32 61, i32 84, i32 13, i32 74, i32 34, i32 39, i32 71, ; 48..55
	i32 86, i32 75, i32 85, i32 30, i32 105, i32 50, i32 95, i32 104, ; 56..63
	i32 70, i32 43, i32 21, i32 14, i32 90, i32 31, i32 49, i32 94, ; 64..71
	i32 81, i32 103, i32 63, i32 78, i32 53, i32 46, i32 93, i32 22, ; 72..79
	i32 72, i32 80, i32 42, i32 37, i32 4, i32 15, i32 10, i32 54, ; 80..87
	i32 5, i32 63, i32 84, i32 80, i32 79, i32 35, i32 65, i32 9, ; 88..95
	i32 61, i32 4, i32 58, i32 101, i32 22, i32 20, i32 12, i32 16, ; 96..103
	i32 87, i32 93, i32 74, i32 64, i32 65, i32 68, i32 28, i32 52, ; 104..111
	i32 41, i32 1, i32 3, i32 2, i32 88, i32 60, i32 102, i32 24, ; 112..119
	i32 106, i32 75, i32 87, i32 46, i32 51, i32 86, i32 72, i32 27, ; 120..127
	i32 12, i32 31, i32 83, i32 77, i32 69, i32 43, i32 26, i32 69, ; 128..135
	i32 77, i32 73, i32 18, i32 92, i32 8, i32 78, i32 20, i32 29, ; 136..143
	i32 50, i32 59, i32 71, i32 56, i32 14, i32 94, i32 100, i32 6, ; 144..151
	i32 16, i32 11, i32 49, i32 99, i32 37, i32 100, i32 47, i32 11, ; 152..159
	i32 35, i32 67, i32 25, i32 45, i32 3, i32 68, i32 21, i32 95, ; 160..167
	i32 48, i32 0, i32 26, i32 1, i32 51, i32 7, i32 25, i32 96, ; 168..175
	i32 40, i32 98, i32 103, i32 92, i32 101, i32 2, i32 66, i32 29, ; 176..183
	i32 58, i32 7, i32 97, i32 36, i32 40, i32 89, i32 44, i32 28, ; 184..191
	i32 38, i32 23, i32 19, i32 73, i32 67, i32 45, i32 39, i32 91, ; 192..199
	i32 76, i32 88, i32 32, i32 59, i32 30, i32 15, i32 17, i32 52, ; 200..207
	i32 99, i32 10, i32 62, i32 44, i32 9, i32 62 ; 208..213
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
