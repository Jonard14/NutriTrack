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
@assembly_image_cache_hashes = local_unnamed_addr constant [216 x i32] [
	i32 32687329, ; 0: Xamarin.AndroidX.Lifecycle.Runtime => 0x1f2c4e1 => 62
	i32 34715100, ; 1: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 84
	i32 39109920, ; 2: Newtonsoft.Json.dll => 0x254c520 => 9
	i32 60940239, ; 3: I18N.Rare.dll => 0x3a1dfcf => 106
	i32 108920425, ; 4: Xamarin.AndroidX.AppCompat.Resources.dll => 0x67dfe69 => 35
	i32 165246403, ; 5: Xamarin.AndroidX.Collection.dll => 0x9d975c3 => 40
	i32 209399409, ; 6: Xamarin.AndroidX.Browser.dll => 0xc7b2e71 => 38
	i32 230216969, ; 7: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0xdb8d509 => 58
	i32 232815796, ; 8: System.Web.Services => 0xde07cb4 => 98
	i32 261689757, ; 9: Xamarin.AndroidX.ConstraintLayout.dll => 0xf99119d => 44
	i32 280482487, ; 10: Xamarin.AndroidX.Interpolator => 0x10b7d2b7 => 57
	i32 318968648, ; 11: Xamarin.AndroidX.Activity.dll => 0x13031348 => 29
	i32 321597661, ; 12: System.Numerics => 0x132b30dd => 21
	i32 337746723, ; 13: I18N.Other.dll => 0x14219b23 => 105
	i32 342366114, ; 14: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 59
	i32 385762202, ; 15: System.Memory.dll => 0x16fe439a => 18
	i32 441335492, ; 16: Xamarin.AndroidX.ConstraintLayout.Core => 0x1a4e3ec4 => 43
	i32 442521989, ; 17: Xamarin.Essentials => 0x1a605985 => 81
	i32 450948140, ; 18: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 56
	i32 465846621, ; 19: mscorlib => 0x1bc4415d => 8
	i32 469710990, ; 20: System.dll => 0x1bff388e => 14
	i32 476646585, ; 21: Xamarin.AndroidX.Interpolator.dll => 0x1c690cb9 => 57
	i32 486930444, ; 22: Xamarin.AndroidX.LocalBroadcastManager.dll => 0x1d05f80c => 66
	i32 526420162, ; 23: System.Transactions.dll => 0x1f6088c2 => 97
	i32 548916678, ; 24: Microsoft.Bcl.AsyncInterfaces => 0x20b7cdc6 => 5
	i32 586578074, ; 25: MimeKit => 0x22f6789a => 6
	i32 605376203, ; 26: System.IO.Compression.FileSystem => 0x24154ecb => 93
	i32 627609679, ; 27: Xamarin.AndroidX.CustomView => 0x2568904f => 49
	i32 639843206, ; 28: Xamarin.AndroidX.Emoji2.ViewsHelper.dll => 0x26233b86 => 55
	i32 643868501, ; 29: System.Net => 0x2660a755 => 19
	i32 662205335, ; 30: System.Text.Encodings.Web.dll => 0x27787397 => 26
	i32 663517072, ; 31: Xamarin.AndroidX.VersionedParcelable => 0x278c7790 => 78
	i32 666292255, ; 32: Xamarin.AndroidX.Arch.Core.Common.dll => 0x27b6d01f => 36
	i32 690569205, ; 33: System.Xml.Linq.dll => 0x29293ff5 => 99
	i32 691348768, ; 34: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 87
	i32 700284507, ; 35: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 85
	i32 709152836, ; 36: System.Security.Cryptography.Pkcs.dll => 0x2a44d044 => 25
	i32 709365442, ; 37: App1 => 0x2a480ec2 => 0
	i32 725851412, ; 38: I18N.West.dll => 0x2b439d14 => 107
	i32 775507847, ; 39: System.IO.Compression => 0x2e394f87 => 92
	i32 790371945, ; 40: Xamarin.AndroidX.CustomView.PoolingContainer.dll => 0x2f1c1e69 => 50
	i32 809851609, ; 41: System.Drawing.Common.dll => 0x30455ad9 => 91
	i32 843511501, ; 42: Xamarin.AndroidX.Print => 0x3246f6cd => 68
	i32 928116545, ; 43: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 84
	i32 945617440, ; 44: I18N.CJK => 0x385cfa20 => 103
	i32 955402788, ; 45: Newtonsoft.Json => 0x38f24a24 => 9
	i32 963428712, ; 46: Xamarin.AndroidX.AppCompat.Resources => 0x396cc168 => 35
	i32 967690846, ; 47: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 59
	i32 1012816738, ; 48: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 72
	i32 1031528504, ; 49: Xamarin.Google.ErrorProne.Annotations.dll => 0x3d7be038 => 83
	i32 1035644815, ; 50: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 34
	i32 1052210849, ; 51: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 63
	i32 1084122840, ; 52: Xamarin.Kotlin.StdLib => 0x409e66d8 => 86
	i32 1098259244, ; 53: System => 0x41761b2c => 14
	i32 1175144683, ; 54: Xamarin.AndroidX.VectorDrawable.Animated => 0x460b48eb => 76
	i32 1204270330, ; 55: Xamarin.AndroidX.Arch.Core.Common => 0x47c7b4fa => 36
	i32 1246548578, ; 56: Xamarin.AndroidX.Collection.Jvm.dll => 0x4a4cd262 => 41
	i32 1264511973, ; 57: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0x4b5eebe5 => 73
	i32 1264890200, ; 58: Xamarin.KotlinX.Coroutines.Core.dll => 0x4b64b158 => 88
	i32 1267360935, ; 59: Xamarin.AndroidX.VectorDrawable => 0x4b8a64a7 => 77
	i32 1275534314, ; 60: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 87
	i32 1278448581, ; 61: Xamarin.AndroidX.Annotation.Jvm => 0x4c3393c5 => 32
	i32 1290254209, ; 62: I18N.Rare => 0x4ce7b781 => 106
	i32 1293217323, ; 63: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 52
	i32 1365406463, ; 64: System.ServiceModel.Internals.dll => 0x516272ff => 96
	i32 1368767823, ; 65: I18N.Other => 0x5195bd4f => 105
	i32 1376866003, ; 66: Xamarin.AndroidX.SavedState => 0x52114ed3 => 72
	i32 1406073936, ; 67: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 45
	i32 1411638395, ; 68: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 23
	i32 1452070440, ; 69: System.Formats.Asn1.dll => 0x568cd628 => 15
	i32 1462112819, ; 70: System.IO.Compression.dll => 0x57261233 => 92
	i32 1469204771, ; 71: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x57924923 => 33
	i32 1582372066, ; 72: Xamarin.AndroidX.DocumentFile.dll => 0x5e5114e2 => 51
	i32 1592978981, ; 73: System.Runtime.Serialization.dll => 0x5ef2ee25 => 95
	i32 1597949149, ; 74: Xamarin.Google.ErrorProne.Annotations => 0x5f3ec4dd => 83
	i32 1599450359, ; 75: I18N.MidEast.dll => 0x5f55acf7 => 104
	i32 1622152042, ; 76: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 65
	i32 1624863272, ; 77: Xamarin.AndroidX.ViewPager2 => 0x60d97228 => 80
	i32 1635184631, ; 78: Xamarin.AndroidX.Emoji2.ViewsHelper => 0x6176eff7 => 55
	i32 1636350590, ; 79: Xamarin.AndroidX.CursorAdapter => 0x6188ba7e => 48
	i32 1639515021, ; 80: System.Net.Http.dll => 0x61b9038d => 20
	i32 1657153582, ; 81: System.Runtime => 0x62c6282e => 24
	i32 1658241508, ; 82: Xamarin.AndroidX.Tracing.Tracing.dll => 0x62d6c1e4 => 74
	i32 1658251792, ; 83: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 82
	i32 1670060433, ; 84: Xamarin.AndroidX.ConstraintLayout => 0x638b1991 => 44
	i32 1729485958, ; 85: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 39
	i32 1733338956, ; 86: MailKit => 0x6750a74c => 4
	i32 1746115085, ; 87: System.IO.Pipelines.dll => 0x68139a0d => 16
	i32 1776026572, ; 88: System.Core.dll => 0x69dc03cc => 11
	i32 1788241197, ; 89: Xamarin.AndroidX.Fragment => 0x6a96652d => 56
	i32 1796167890, ; 90: Microsoft.Bcl.AsyncInterfaces.dll => 0x6b0f58d2 => 5
	i32 1808609942, ; 91: Xamarin.AndroidX.Loader => 0x6bcd3296 => 65
	i32 1813058853, ; 92: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 86
	i32 1813201214, ; 93: Xamarin.Google.Android.Material => 0x6c13413e => 82
	i32 1867746548, ; 94: Xamarin.Essentials.dll => 0x6f538cf4 => 81
	i32 1885316902, ; 95: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0x705fa726 => 37
	i32 1919157823, ; 96: Xamarin.AndroidX.MultiDex.dll => 0x7264063f => 67
	i32 2011961780, ; 97: System.Buffers.dll => 0x77ec19b4 => 10
	i32 2019465201, ; 98: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 63
	i32 2026931361, ; 99: MailKit.dll => 0x78d084a1 => 4
	i32 2055257422, ; 100: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 60
	i32 2067863569, ; 101: I18N.dll => 0x7b411811 => 102
	i32 2079903147, ; 102: System.Runtime.dll => 0x7bf8cdab => 24
	i32 2090596640, ; 103: System.Numerics.Vectors => 0x7c9bf920 => 22
	i32 2142278582, ; 104: System.Data.OleDb.dll => 0x7fb093b6 => 13
	i32 2188064486, ; 105: System.Json.dll => 0x826b36e6 => 17
	i32 2201107256, ; 106: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 89
	i32 2201231467, ; 107: System.Net.Http => 0x8334206b => 20
	i32 2217644978, ; 108: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x842e93b2 => 76
	i32 2244775296, ; 109: Xamarin.AndroidX.LocalBroadcastManager => 0x85cc8d80 => 66
	i32 2256548716, ; 110: Xamarin.AndroidX.MultiDex => 0x8680336c => 67
	i32 2279755925, ; 111: Xamarin.AndroidX.RecyclerView.dll => 0x87e25095 => 70
	i32 2315684594, ; 112: Xamarin.AndroidX.Annotation.dll => 0x8a068af2 => 30
	i32 2403452196, ; 113: Xamarin.AndroidX.Emoji2.dll => 0x8f41c524 => 54
	i32 2465532216, ; 114: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x92f50938 => 43
	i32 2471841756, ; 115: netstandard.dll => 0x93554fdc => 1
	i32 2475788418, ; 116: Java.Interop.dll => 0x93918882 => 3
	i32 2498657740, ; 117: BouncyCastle.Cryptography.dll => 0x94ee7dcc => 2
	i32 2501346920, ; 118: System.Data.DataSetExtensions => 0x95178668 => 90
	i32 2505896520, ; 119: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x955cf248 => 62
	i32 2521135010, ; 120: I18N.CJK.dll => 0x964577a2 => 103
	i32 2570120770, ; 121: System.Text.Encodings.Web => 0x9930ee42 => 26
	i32 2581274016, ; 122: I18N.West => 0x99db1da0 => 107
	i32 2581819634, ; 123: Xamarin.AndroidX.VectorDrawable.dll => 0x99e370f2 => 77
	i32 2605712449, ; 124: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 89
	i32 2620871830, ; 125: Xamarin.AndroidX.CursorAdapter.dll => 0x9c375496 => 48
	i32 2624644809, ; 126: Xamarin.AndroidX.DynamicAnimation => 0x9c70e6c9 => 53
	i32 2671474046, ; 127: Xamarin.KotlinX.Coroutines.Core => 0x9f3b757e => 88
	i32 2701096212, ; 128: Xamarin.AndroidX.Tracing.Tracing => 0xa0ff7514 => 74
	i32 2732626843, ; 129: Xamarin.AndroidX.Activity => 0xa2e0939b => 29
	i32 2736590120, ; 130: System.Data.OleDb => 0xa31d0d28 => 13
	i32 2737747696, ; 131: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0xa32eb6f0 => 33
	i32 2770495804, ; 132: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 85
	i32 2778768386, ; 133: Xamarin.AndroidX.ViewPager.dll => 0xa5a0a402 => 79
	i32 2779977773, ; 134: Xamarin.AndroidX.ResourceInspection.Annotation.dll => 0xa5b3182d => 71
	i32 2810250172, ; 135: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 45
	i32 2819470561, ; 136: System.Xml.dll => 0xa80db4e1 => 28
	i32 2821294376, ; 137: Xamarin.AndroidX.ResourceInspection.Annotation => 0xa8298928 => 71
	i32 2853208004, ; 138: Xamarin.AndroidX.ViewPager => 0xaa107fc4 => 79
	i32 2855708567, ; 139: Xamarin.AndroidX.Transition => 0xaa36a797 => 75
	i32 2887636118, ; 140: System.Net.dll => 0xac1dd496 => 19
	i32 2903344695, ; 141: System.ComponentModel.Composition => 0xad0d8637 => 94
	i32 2905242038, ; 142: mscorlib.dll => 0xad2a79b6 => 8
	i32 2916838712, ; 143: Xamarin.AndroidX.ViewPager2.dll => 0xaddb6d38 => 80
	i32 2919462931, ; 144: System.Numerics.Vectors.dll => 0xae037813 => 22
	i32 2921128767, ; 145: Xamarin.AndroidX.Annotation.Experimental.dll => 0xae1ce33f => 31
	i32 2978675010, ; 146: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 52
	i32 2996846495, ; 147: Xamarin.AndroidX.Lifecycle.Process.dll => 0xb2a03f9f => 61
	i32 3016983068, ; 148: Xamarin.AndroidX.Startup.StartupRuntime => 0xb3d3821c => 73
	i32 3024354802, ; 149: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xb443fdf2 => 58
	i32 3103600923, ; 150: System.Formats.Asn1 => 0xb8fd311b => 15
	i32 3111772706, ; 151: System.Runtime.Serialization => 0xb979e222 => 95
	i32 3124832203, ; 152: System.Threading.Tasks.Extensions => 0xba4127cb => 101
	i32 3171180504, ; 153: MimeKit.dll => 0xbd045fd8 => 6
	i32 3201217166, ; 154: System.Json => 0xbeceb28e => 17
	i32 3204380047, ; 155: System.Data.dll => 0xbefef58f => 12
	i32 3211777861, ; 156: Xamarin.AndroidX.DocumentFile => 0xbf6fd745 => 51
	i32 3247949154, ; 157: Mono.Security => 0xc197c562 => 100
	i32 3258312781, ; 158: Xamarin.AndroidX.CardView => 0xc235e84d => 39
	i32 3265893370, ; 159: System.Threading.Tasks.Extensions.dll => 0xc2a993fa => 101
	i32 3317135071, ; 160: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 49
	i32 3317144872, ; 161: System.Data => 0xc5b79d28 => 12
	i32 3340431453, ; 162: Xamarin.AndroidX.Arch.Core.Runtime => 0xc71af05d => 37
	i32 3345895724, ; 163: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xc76e512c => 69
	i32 3358260929, ; 164: System.Text.Json => 0xc82afec1 => 27
	i32 3362522851, ; 165: Xamarin.AndroidX.Core => 0xc86c06e3 => 47
	i32 3366347497, ; 166: Java.Interop => 0xc8a662e9 => 3
	i32 3374999561, ; 167: Xamarin.AndroidX.RecyclerView => 0xc92a6809 => 70
	i32 3395150330, ; 168: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 23
	i32 3404865022, ; 169: System.ServiceModel.Internals => 0xcaf21dfe => 96
	i32 3405233483, ; 170: Xamarin.AndroidX.CustomView.PoolingContainer => 0xcaf7bd4b => 50
	i32 3414721009, ; 171: App1.dll => 0xcb8881f1 => 0
	i32 3429136800, ; 172: System.Xml => 0xcc6479a0 => 28
	i32 3430777524, ; 173: netstandard => 0xcc7d82b4 => 1
	i32 3441283291, ; 174: Xamarin.AndroidX.DynamicAnimation.dll => 0xcd1dd0db => 53
	i32 3476120550, ; 175: Mono.Android => 0xcf3163e6 => 7
	i32 3485117614, ; 176: System.Text.Json.dll => 0xcfbaacae => 27
	i32 3486566296, ; 177: System.Transactions => 0xcfd0c798 => 97
	i32 3493954962, ; 178: Xamarin.AndroidX.Concurrent.Futures.dll => 0xd0418592 => 42
	i32 3509114376, ; 179: System.Xml.Linq => 0xd128d608 => 99
	i32 3540208256, ; 180: I18N.MidEast => 0xd3034a80 => 104
	i32 3567349600, ; 181: System.ComponentModel.Composition.dll => 0xd4a16f60 => 94
	i32 3579244613, ; 182: I18N => 0xd556f045 => 102
	i32 3605570793, ; 183: BouncyCastle.Cryptography => 0xd6e8a4e9 => 2
	i32 3627220390, ; 184: Xamarin.AndroidX.Print.dll => 0xd832fda6 => 68
	i32 3633644679, ; 185: Xamarin.AndroidX.Annotation.Experimental => 0xd8950487 => 31
	i32 3641597786, ; 186: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 60
	i32 3672681054, ; 187: Mono.Android.dll => 0xdae8aa5e => 7
	i32 3676310014, ; 188: System.Web.Services.dll => 0xdb2009fe => 98
	i32 3682565725, ; 189: Xamarin.AndroidX.Browser => 0xdb7f7e5d => 38
	i32 3684561358, ; 190: Xamarin.AndroidX.Concurrent.Futures => 0xdb9df1ce => 42
	i32 3689375977, ; 191: System.Drawing.Common => 0xdbe768e9 => 91
	i32 3706696989, ; 192: Xamarin.AndroidX.Core.Core.Ktx.dll => 0xdcefb51d => 46
	i32 3718780102, ; 193: Xamarin.AndroidX.Annotation => 0xdda814c6 => 30
	i32 3786282454, ; 194: Xamarin.AndroidX.Collection => 0xe1ae15d6 => 40
	i32 3807198597, ; 195: System.Security.Cryptography.Pkcs => 0xe2ed3d85 => 25
	i32 3829621856, ; 196: System.Numerics.dll => 0xe4436460 => 21
	i32 3885922214, ; 197: Xamarin.AndroidX.Transition.dll => 0xe79e77a6 => 75
	i32 3888767677, ; 198: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0xe7c9e2bd => 69
	i32 3896760992, ; 199: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 47
	i32 3910130544, ; 200: Xamarin.AndroidX.Collection.Jvm => 0xe90fdb70 => 41
	i32 3920810846, ; 201: System.IO.Compression.FileSystem.dll => 0xe9b2d35e => 93
	i32 3921031405, ; 202: Xamarin.AndroidX.VersionedParcelable.dll => 0xe9b630ed => 78
	i32 3945713374, ; 203: System.Data.DataSetExtensions.dll => 0xeb2ecede => 90
	i32 3955647286, ; 204: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 34
	i32 3959773229, ; 205: Xamarin.AndroidX.Lifecycle.Process => 0xec05582d => 61
	i32 4015948917, ; 206: Xamarin.AndroidX.Annotation.Jvm.dll => 0xef5e8475 => 32
	i32 4023392905, ; 207: System.IO.Pipelines => 0xefd01a89 => 16
	i32 4025784931, ; 208: System.Memory => 0xeff49a63 => 18
	i32 4101593132, ; 209: Xamarin.AndroidX.Emoji2 => 0xf479582c => 54
	i32 4105002889, ; 210: Mono.Security.dll => 0xf4ad5f89 => 100
	i32 4151237749, ; 211: System.Core => 0xf76edc75 => 11
	i32 4182413190, ; 212: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0xf94a8f86 => 64
	i32 4256097574, ; 213: Xamarin.AndroidX.Core.Core.Ktx => 0xfdaee526 => 46
	i32 4260525087, ; 214: System.Buffers => 0xfdf2741f => 10
	i32 4292120959 ; 215: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xffd4917f => 64
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [216 x i32] [
	i32 62, i32 84, i32 9, i32 106, i32 35, i32 40, i32 38, i32 58, ; 0..7
	i32 98, i32 44, i32 57, i32 29, i32 21, i32 105, i32 59, i32 18, ; 8..15
	i32 43, i32 81, i32 56, i32 8, i32 14, i32 57, i32 66, i32 97, ; 16..23
	i32 5, i32 6, i32 93, i32 49, i32 55, i32 19, i32 26, i32 78, ; 24..31
	i32 36, i32 99, i32 87, i32 85, i32 25, i32 0, i32 107, i32 92, ; 32..39
	i32 50, i32 91, i32 68, i32 84, i32 103, i32 9, i32 35, i32 59, ; 40..47
	i32 72, i32 83, i32 34, i32 63, i32 86, i32 14, i32 76, i32 36, ; 48..55
	i32 41, i32 73, i32 88, i32 77, i32 87, i32 32, i32 106, i32 52, ; 56..63
	i32 96, i32 105, i32 72, i32 45, i32 23, i32 15, i32 92, i32 33, ; 64..71
	i32 51, i32 95, i32 83, i32 104, i32 65, i32 80, i32 55, i32 48, ; 72..79
	i32 20, i32 24, i32 74, i32 82, i32 44, i32 39, i32 4, i32 16, ; 80..87
	i32 11, i32 56, i32 5, i32 65, i32 86, i32 82, i32 81, i32 37, ; 88..95
	i32 67, i32 10, i32 63, i32 4, i32 60, i32 102, i32 24, i32 22, ; 96..103
	i32 13, i32 17, i32 89, i32 20, i32 76, i32 66, i32 67, i32 70, ; 104..111
	i32 30, i32 54, i32 43, i32 1, i32 3, i32 2, i32 90, i32 62, ; 112..119
	i32 103, i32 26, i32 107, i32 77, i32 89, i32 48, i32 53, i32 88, ; 120..127
	i32 74, i32 29, i32 13, i32 33, i32 85, i32 79, i32 71, i32 45, ; 128..135
	i32 28, i32 71, i32 79, i32 75, i32 19, i32 94, i32 8, i32 80, ; 136..143
	i32 22, i32 31, i32 52, i32 61, i32 73, i32 58, i32 15, i32 95, ; 144..151
	i32 101, i32 6, i32 17, i32 12, i32 51, i32 100, i32 39, i32 101, ; 152..159
	i32 49, i32 12, i32 37, i32 69, i32 27, i32 47, i32 3, i32 70, ; 160..167
	i32 23, i32 96, i32 50, i32 0, i32 28, i32 1, i32 53, i32 7, ; 168..175
	i32 27, i32 97, i32 42, i32 99, i32 104, i32 94, i32 102, i32 2, ; 176..183
	i32 68, i32 31, i32 60, i32 7, i32 98, i32 38, i32 42, i32 91, ; 184..191
	i32 46, i32 30, i32 40, i32 25, i32 21, i32 75, i32 69, i32 47, ; 192..199
	i32 41, i32 93, i32 78, i32 90, i32 34, i32 61, i32 32, i32 16, ; 200..207
	i32 18, i32 54, i32 100, i32 11, i32 64, i32 46, i32 10, i32 64 ; 216..215
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
