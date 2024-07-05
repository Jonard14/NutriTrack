; ModuleID = 'obj\Debug\130\android\marshal_methods.arm64-v8a.ll'
source_filename = "obj\Debug\130\android\marshal_methods.arm64-v8a.ll"
target datalayout = "e-m:e-i8:8:32-i16:16:32-i64:64-i128:128-n32:64-S128"
target triple = "aarch64-unknown-linux-android"


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
@assembly_image_cache = local_unnamed_addr global [0 x %struct.MonoImage*] zeroinitializer, align 8
; Each entry maps hash of an assembly name to an index into the `assembly_image_cache` array
@assembly_image_cache_hashes = local_unnamed_addr constant [214 x i64] [
	i64 24362543149721218, ; 0: Xamarin.AndroidX.DynamicAnimation => 0x568d9a9a43a682 => 51
	i64 120698629574877762, ; 1: Mono.Android => 0x1accec39cafe242 => 7
	i64 156291772854606065, ; 2: I18N.West => 0x22b428a125098f1 => 106
	i64 210515253464952879, ; 3: Xamarin.AndroidX.Collection.dll => 0x2ebe681f694702f => 38
	i64 232391251801502327, ; 4: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 70
	i64 233177144301842968, ; 5: Xamarin.AndroidX.Collection.Jvm.dll => 0x33c696097d9f218 => 39
	i64 316157742385208084, ; 6: Xamarin.AndroidX.Core.Core.Ktx.dll => 0x46337caa7dc1b14 => 44
	i64 456145817121827372, ; 7: App1.dll => 0x6548e343353aa2c => 0
	i64 634308326490598313, ; 8: Xamarin.AndroidX.Lifecycle.Runtime.dll => 0x8cd840fee8b6ba9 => 60
	i64 702024105029695270, ; 9: System.Drawing.Common => 0x9be17343c0e7726 => 89
	i64 872800313462103108, ; 10: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 50
	i64 940822596282819491, ; 11: System.Transactions => 0xd0e792aa81923a3 => 96
	i64 1000557547492888992, ; 12: Mono.Security.dll => 0xde2b1c9cba651a0 => 99
	i64 1120440138749646132, ; 13: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 80
	i64 1315114680217950157, ; 14: Xamarin.AndroidX.Arch.Core.Common.dll => 0x124039d5794ad7cd => 34
	i64 1425944114962822056, ; 15: System.Runtime.Serialization.dll => 0x13c9f89e19eaf3a8 => 94
	i64 1493452499941003209, ; 16: I18N.CJK => 0x14b9cf22d3e70fc9 => 102
	i64 1624659445732251991, ; 17: Xamarin.AndroidX.AppCompat.AppCompatResources.dll => 0x168bf32877da9957 => 31
	i64 1628611045998245443, ; 18: Xamarin.AndroidX.Lifecycle.ViewModelSavedState.dll => 0x1699fd1e1a00b643 => 62
	i64 1636321030536304333, ; 19: Xamarin.AndroidX.Legacy.Support.Core.Utils.dll => 0x16b5614ec39e16cd => 56
	i64 1682513316613008342, ; 20: System.Net.dll => 0x17597cf276952bd6 => 18
	i64 1743969030606105336, ; 21: System.Memory.dll => 0x1833d297e88f2af8 => 17
	i64 1795316252682057001, ; 22: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 32
	i64 1836611346387731153, ; 23: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 70
	i64 1865037103900624886, ; 24: Microsoft.Bcl.AsyncInterfaces => 0x19e1f15d56eb87f6 => 5
	i64 1875917498431009007, ; 25: Xamarin.AndroidX.Annotation.dll => 0x1a08990699eb70ef => 28
	i64 1963507636676687784, ; 26: MimeKit => 0x1b3fc7cadde177a8 => 6
	i64 1981742497975770890, ; 27: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 61
	i64 2040001226662520565, ; 28: System.Threading.Tasks.Extensions.dll => 0x1c4f8a4ea894a6f5 => 100
	i64 2136356949452311481, ; 29: Xamarin.AndroidX.MultiDex.dll => 0x1da5dd539d8acbb9 => 65
	i64 2165725771938924357, ; 30: Xamarin.AndroidX.Browser => 0x1e0e341d75540745 => 36
	i64 2203565783020068373, ; 31: Xamarin.KotlinX.Coroutines.Core => 0x1e94a367981dde15 => 86
	i64 2262844636196693701, ; 32: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 50
	i64 2284400282711631002, ; 33: System.Web.Services => 0x1fb3d1f42fd4249a => 97
	i64 2304837677853103545, ; 34: Xamarin.AndroidX.ResourceInspection.Annotation.dll => 0x1ffc6da80d5ed5b9 => 69
	i64 2329709569556905518, ; 35: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 58
	i64 2335503487726329082, ; 36: System.Text.Encodings.Web => 0x2069600c4d9d1cfa => 24
	i64 2337758774805907496, ; 37: System.Runtime.CompilerServices.Unsafe => 0x207163383edbc828 => 21
	i64 2470498323731680442, ; 38: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 43
	i64 2479423007379663237, ; 39: Xamarin.AndroidX.VectorDrawable.Animated.dll => 0x2268ae16b2cba985 => 74
	i64 2497223385847772520, ; 40: System.Runtime => 0x22a7eb7046413568 => 22
	i64 2547086958574651984, ; 41: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 27
	i64 2592350477072141967, ; 42: System.Xml.dll => 0x23f9e10627330e8f => 26
	i64 2624866290265602282, ; 43: mscorlib.dll => 0x246d65fbde2db8ea => 8
	i64 2783046991838674048, ; 44: System.Runtime.CompilerServices.Unsafe.dll => 0x269f5e7e6dc37c80 => 21
	i64 2787234703088983483, ; 45: Xamarin.AndroidX.Startup.StartupRuntime => 0x26ae3f31ef429dbb => 71
	i64 3017704767998173186, ; 46: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 80
	i64 3289520064315143713, ; 47: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 57
	i64 3303437397778967116, ; 48: Xamarin.AndroidX.Annotation.Experimental => 0x2dd82acf985b2a4c => 29
	i64 3311221304742556517, ; 49: System.Numerics.Vectors.dll => 0x2df3d23ba9e2b365 => 20
	i64 3344514922410554693, ; 50: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x2e6a1a9a18463545 => 87
	i64 3493805808809882663, ; 51: Xamarin.AndroidX.Tracing.Tracing.dll => 0x307c7ddf444f3427 => 72
	i64 3531994851595924923, ; 52: System.Numerics => 0x31042a9aade235bb => 19
	i64 3571415421602489686, ; 53: System.Runtime.dll => 0x319037675df7e556 => 22
	i64 3572576518857361216, ; 54: I18N => 0x3194576a63650740 => 101
	i64 3716579019761409177, ; 55: netstandard.dll => 0x3393f0ed5c8c5c99 => 1
	i64 3727469159507183293, ; 56: Xamarin.AndroidX.RecyclerView => 0x33baa1739ba646bd => 68
	i64 3772598417116884899, ; 57: Xamarin.AndroidX.DynamicAnimation.dll => 0x345af645b473efa3 => 51
	i64 3966267475168208030, ; 58: System.Memory => 0x370b03412596249e => 17
	i64 4201423742386704971, ; 59: Xamarin.AndroidX.Core.Core.Ktx => 0x3a4e74a233da124b => 44
	i64 4525561845656915374, ; 60: System.ServiceModel.Internals => 0x3ece06856b710dae => 95
	i64 4636684751163556186, ; 61: Xamarin.AndroidX.VersionedParcelable.dll => 0x4058d0370893015a => 76
	i64 4759461199762736555, ; 62: Xamarin.AndroidX.Lifecycle.Process.dll => 0x420d00be961cc5ab => 59
	i64 4794310189461587505, ; 63: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 27
	i64 5203618020066742981, ; 64: Xamarin.Essentials => 0x4836f704f0e652c5 => 79
	i64 5205316157927637098, ; 65: Xamarin.AndroidX.LocalBroadcastManager => 0x483cff7778e0c06a => 64
	i64 5376510917114486089, ; 66: Xamarin.AndroidX.VectorDrawable.Animated => 0x4a9d3431719e5d49 => 74
	i64 5382384903084550500, ; 67: MailKit.dll => 0x4ab2128d60c7a964 => 4
	i64 5398069113008343190, ; 68: I18N.West.dll => 0x4ae9cb4211dec896 => 106
	i64 5408338804355907810, ; 69: Xamarin.AndroidX.Transition => 0x4b0e477cea9840e2 => 73
	i64 5451019430259338467, ; 70: Xamarin.AndroidX.ConstraintLayout.dll => 0x4ba5e94a845c2ce3 => 42
	i64 5507995362134886206, ; 71: System.Core.dll => 0x4c705499688c873e => 10
	i64 5574231584441077149, ; 72: Xamarin.AndroidX.Annotation.Jvm => 0x4d5ba617ae5f8d9d => 30
	i64 5692067934154308417, ; 73: Xamarin.AndroidX.ViewPager2.dll => 0x4efe49a0d4a8bb41 => 78
	i64 5757522595884336624, ; 74: Xamarin.AndroidX.Concurrent.Futures.dll => 0x4fe6d44bd9f885f0 => 40
	i64 5878178646025157113, ; 75: I18N.Other => 0x51937c55aa9db9f9 => 104
	i64 5917160574407189813, ; 76: App1 => 0x521dfa31247ca535 => 0
	i64 5979151488806146654, ; 77: System.Formats.Asn1 => 0x52fa3699a489d25e => 14
	i64 6222399776351216807, ; 78: System.Text.Json.dll => 0x565a67a0ffe264a7 => 25
	i64 6319713645133255417, ; 79: Xamarin.AndroidX.Lifecycle.Runtime => 0x57b42213b45b52f9 => 60
	i64 6401687960814735282, ; 80: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 58
	i64 6433271170595107064, ; 81: MimeKit.dll => 0x5947920b731530f8 => 6
	i64 6504860066809920875, ; 82: Xamarin.AndroidX.Browser.dll => 0x5a45e7c43bd43d6b => 36
	i64 6548213210057960872, ; 83: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 47
	i64 6589202984700901502, ; 84: Xamarin.Google.ErrorProne.Annotations.dll => 0x5b718d34180a787e => 81
	i64 6591024623626361694, ; 85: System.Web.Services.dll => 0x5b7805f9751a1b5e => 97
	i64 6876862101832370452, ; 86: System.Xml.Linq => 0x5f6f85a57d108914 => 98
	i64 6894844156784520562, ; 87: System.Numerics.Vectors => 0x5faf683aead1ad72 => 20
	i64 7103753931438454322, ; 88: Xamarin.AndroidX.Interpolator.dll => 0x62959a90372c7632 => 55
	i64 7105430439328552570, ; 89: System.Security.Cryptography.Pkcs => 0x629b8f56a06d167a => 23
	i64 7488575175965059935, ; 90: System.Xml.Linq.dll => 0x67ecc3724534ab5f => 98
	i64 7637365915383206639, ; 91: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 79
	i64 7654504624184590948, ; 92: System.Net.Http => 0x6a3a4366801b8264 => 93
	i64 7735352534559001595, ; 93: Xamarin.Kotlin.StdLib.dll => 0x6b597e2582ce8bfb => 84
	i64 7747785289863678794, ; 94: I18N.Rare => 0x6b85a9abee524b4a => 105
	i64 7820441508502274321, ; 95: System.Data => 0x6c87ca1e14ff8111 => 11
	i64 7836164640616011524, ; 96: Xamarin.AndroidX.AppCompat.AppCompatResources => 0x6cbfa6390d64d704 => 31
	i64 7867610841234767674, ; 97: I18N.Rare.dll => 0x6d2f5e602ecf7f3a => 105
	i64 8044118961405839122, ; 98: System.ComponentModel.Composition => 0x6fa2739369944712 => 92
	i64 8083354569033831015, ; 99: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 57
	i64 8103644804370223335, ; 100: System.Data.DataSetExtensions.dll => 0x7075ee03be6d50e7 => 88
	i64 8167236081217502503, ; 101: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 3
	i64 8187640529827139739, ; 102: Xamarin.KotlinX.Coroutines.Android => 0x71a057ae90f0109b => 85
	i64 8265650852517415196, ; 103: I18N.dll => 0x72b57da835b4891c => 101
	i64 8398329775253868912, ; 104: Xamarin.AndroidX.ConstraintLayout.Core.dll => 0x748cdc6f3097d170 => 41
	i64 8426919725312979251, ; 105: Xamarin.AndroidX.Lifecycle.Process => 0x74f26ed7aa033133 => 59
	i64 8598790081731763592, ; 106: Xamarin.AndroidX.Emoji2.ViewsHelper.dll => 0x77550a055fc61d88 => 53
	i64 8601935802264776013, ; 107: Xamarin.AndroidX.Transition.dll => 0x7760370982b4ed4d => 73
	i64 8618070908946355220, ; 108: I18N.MidEast => 0x779989d4c8e01414 => 103
	i64 8626175481042262068, ; 109: Java.Interop => 0x77b654e585b55834 => 3
	i64 8684531736582871431, ; 110: System.IO.Compression.FileSystem => 0x7885a79a0fa0d987 => 91
	i64 8951477988056063522, ; 111: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller => 0x7c3a09cd9ccf5e22 => 67
	i64 9031035476476434958, ; 112: Xamarin.KotlinX.Coroutines.Core.dll => 0x7d54aeead9541a0e => 86
	i64 9286073997824813334, ; 113: BouncyCastle.Cryptography => 0x80dec319ee56e916 => 2
	i64 9312692141327339315, ; 114: Xamarin.AndroidX.ViewPager2 => 0x813d54296a634f33 => 78
	i64 9324707631942237306, ; 115: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 32
	i64 9662334977499516867, ; 116: System.Numerics.dll => 0x8617827802b0cfc3 => 19
	i64 9678050649315576968, ; 117: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 43
	i64 9808709177481450983, ; 118: Mono.Android.dll => 0x881f890734e555e7 => 7
	i64 9825649861376906464, ; 119: Xamarin.AndroidX.Concurrent.Futures => 0x885bb87d8abc94e0 => 40
	i64 9834056768316610435, ; 120: System.Transactions.dll => 0x8879968718899783 => 96
	i64 9907349773706910547, ; 121: Xamarin.AndroidX.Emoji2.ViewsHelper => 0x897dfa20b758db53 => 53
	i64 9998632235833408227, ; 122: Mono.Security => 0x8ac2470b209ebae3 => 99
	i64 10038780035334861115, ; 123: System.Net.Http.dll => 0x8b50e941206af13b => 93
	i64 10229024438826829339, ; 124: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 47
	i64 10321854143672141184, ; 125: Xamarin.Jetbrains.Annotations.dll => 0x8f3e97a7f8f8c580 => 83
	i64 10376576884623852283, ; 126: Xamarin.AndroidX.Tracing.Tracing => 0x900101b2f888c2fb => 72
	i64 10406448008575299332, ; 127: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x906b2153fcb3af04 => 87
	i64 10430153318873392755, ; 128: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 45
	i64 10447083246144586668, ; 129: Microsoft.Bcl.AsyncInterfaces.dll => 0x90fb7edc816203ac => 5
	i64 10841941198020570030, ; 130: I18N.MidEast.dll => 0x9676501397b06bae => 103
	i64 10847732767863316357, ; 131: Xamarin.AndroidX.Arch.Core.Common => 0x968ae37a86db9f85 => 34
	i64 11019817191295005410, ; 132: Xamarin.AndroidX.Annotation.Jvm.dll => 0x98ee415998e1b2e2 => 30
	i64 11023048688141570732, ; 133: System.Core => 0x98f9bc61168392ac => 10
	i64 11037814507248023548, ; 134: System.Xml => 0x992e31d0412bf7fc => 26
	i64 11071824625609515081, ; 135: Xamarin.Google.ErrorProne.Annotations => 0x99a705d600e0a049 => 81
	i64 11162124722117608902, ; 136: Xamarin.AndroidX.ViewPager => 0x9ae7d54b986d05c6 => 77
	i64 11202883116519673972, ; 137: Xamarin.AndroidX.AppCompat.Resources => 0x9b78a2d6cc605074 => 33
	i64 11299661109949763898, ; 138: Xamarin.AndroidX.Collection.Jvm => 0x9cd075e94cda113a => 39
	i64 11340910727871153756, ; 139: Xamarin.AndroidX.CursorAdapter => 0x9d630238642d465c => 46
	i64 11392833485892708388, ; 140: Xamarin.AndroidX.Print.dll => 0x9e1b79b18fcf6824 => 66
	i64 11513602507638267977, ; 141: System.IO.Pipelines.dll => 0x9fc8887aa0d36049 => 15
	i64 11529969570048099689, ; 142: Xamarin.AndroidX.ViewPager.dll => 0xa002ae3c4dc7c569 => 77
	i64 11580057168383206117, ; 143: Xamarin.AndroidX.Annotation => 0xa0b4a0a4103262e5 => 28
	i64 11591352189662810718, ; 144: Xamarin.AndroidX.Startup.StartupRuntime.dll => 0xa0dcc167234c525e => 71
	i64 11597940890313164233, ; 145: netstandard => 0xa0f429ca8d1805c9 => 1
	i64 11672361001936329215, ; 146: Xamarin.AndroidX.Interpolator => 0xa1fc8e7d0a8999ff => 55
	i64 11991047634523762324, ; 147: System.Net => 0xa668c24ad493ae94 => 18
	i64 12102847907131387746, ; 148: System.Buffers => 0xa7f5f40c43256f62 => 9
	i64 12137774235383566651, ; 149: Xamarin.AndroidX.VectorDrawable => 0xa872095bbfed113b => 75
	i64 12145679461940342714, ; 150: System.Text.Json => 0xa88e1f1ebcb62fba => 25
	i64 12313367145828839434, ; 151: System.IO.Pipelines => 0xaae1de2e1c17f00a => 15
	i64 12451044538927396471, ; 152: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 54
	i64 12466513435562512481, ; 153: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 63
	i64 12487638416075308985, ; 154: Xamarin.AndroidX.DocumentFile.dll => 0xad4d00fa21b0bfb9 => 49
	i64 12538491095302438457, ; 155: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 37
	i64 12550732019250633519, ; 156: System.IO.Compression => 0xae2d28465e8e1b2f => 90
	i64 12700543734426720211, ; 157: Xamarin.AndroidX.Collection => 0xb041653c70d157d3 => 38
	i64 12963446364377008305, ; 158: System.Drawing.Common.dll => 0xb3e769c8fd8548b1 => 89
	i64 12982280885948128408, ; 159: Xamarin.AndroidX.CustomView.PoolingContainer => 0xb42a53aec5481c98 => 48
	i64 12986822521348711275, ; 160: I18N.Other.dll => 0xb43a7646aa08636b => 104
	i64 13129914918964716986, ; 161: Xamarin.AndroidX.Emoji2.dll => 0xb636d40db3fe65ba => 52
	i64 13370592475155966277, ; 162: System.Runtime.Serialization => 0xb98de304062ea945 => 94
	i64 13401370062847626945, ; 163: Xamarin.AndroidX.VectorDrawable.dll => 0xb9fb3b1193964ec1 => 75
	i64 13404347523447273790, ; 164: Xamarin.AndroidX.ConstraintLayout.Core => 0xba05cf0da4f6393e => 41
	i64 13454009404024712428, ; 165: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 82
	i64 13458671083851642139, ; 166: System.Json.dll => 0xbac6ce0b2dcc751b => 16
	i64 13465488254036897740, ; 167: Xamarin.Kotlin.StdLib => 0xbadf06394d106fcc => 84
	i64 13491513212026656886, ; 168: Xamarin.AndroidX.Arch.Core.Runtime.dll => 0xbb3b7bc905569876 => 35
	i64 13572454107664307259, ; 169: Xamarin.AndroidX.RecyclerView.dll => 0xbc5b0b19d99f543b => 68
	i64 13621154251410165619, ; 170: Xamarin.AndroidX.CustomView.PoolingContainer.dll => 0xbd080f9faa1acf73 => 48
	i64 13647894001087880694, ; 171: System.Data.dll => 0xbd670f48cb071df6 => 11
	i64 13959074834287824816, ; 172: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 54
	i64 13961013029440053076, ; 173: MailKit => 0xc1bf7b61b45fdf54 => 4
	i64 14109164557138018902, ; 174: System.Data.OleDb => 0xc3cdd26941be4256 => 12
	i64 14124974489674258913, ; 175: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 37
	i64 14172845254133543601, ; 176: Xamarin.AndroidX.MultiDex => 0xc4b00faaed35f2b1 => 65
	i64 14261073672896646636, ; 177: Xamarin.AndroidX.Print => 0xc5e982f274ae0dec => 66
	i64 14495724990987328804, ; 178: Xamarin.AndroidX.ResourceInspection.Annotation => 0xc92b2913e18d5d24 => 69
	i64 14551742072151931844, ; 179: System.Text.Encodings.Web.dll => 0xc9f22c50f1b8fbc4 => 24
	i64 14644440854989303794, ; 180: Xamarin.AndroidX.LocalBroadcastManager.dll => 0xcb3b815e37daeff2 => 64
	i64 14792063746108907174, ; 181: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 82
	i64 14852515768018889994, ; 182: Xamarin.AndroidX.CursorAdapter.dll => 0xce1ebc6625a76d0a => 46
	i64 14987728460634540364, ; 183: System.IO.Compression.dll => 0xcfff1ba06622494c => 90
	i64 14988210264188246988, ; 184: Xamarin.AndroidX.DocumentFile => 0xd000d1d307cddbcc => 49
	i64 15150743910298169673, ; 185: Xamarin.AndroidX.ProfileInstaller.ProfileInstaller.dll => 0xd2424150783c3149 => 67
	i64 15279429628684179188, ; 186: Xamarin.KotlinX.Coroutines.Android.dll => 0xd40b704b1c4c96f4 => 85
	i64 15370334346939861994, ; 187: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 45
	i64 15582737692548360875, ; 188: Xamarin.AndroidX.Lifecycle.ViewModelSavedState => 0xd841015ed86f6aab => 62
	i64 15609085926864131306, ; 189: System.dll => 0xd89e9cf3334914ea => 13
	i64 15620612276725577442, ; 190: BouncyCastle.Cryptography.dll => 0xd8c7901aa85576e2 => 2
	i64 15728157151893626066, ; 191: I18N.CJK.dll => 0xda45a3992a239cd2 => 102
	i64 15963349826457351533, ; 192: System.Threading.Tasks.Extensions => 0xdd893616f748b56d => 100
	i64 16154507427712707110, ; 193: System => 0xe03056ea4e39aa26 => 13
	i64 16259387015512368243, ; 194: Xamarin.AndroidX.AppCompat.Resources.dll => 0xe1a4f2583d36a473 => 33
	i64 16565028646146589191, ; 195: System.ComponentModel.Composition.dll => 0xe5e2cdc9d3bcc207 => 92
	i64 16621146507174665210, ; 196: Xamarin.AndroidX.ConstraintLayout => 0xe6aa2caf87dedbfa => 42
	i64 16822611501064131242, ; 197: System.Data.DataSetExtensions => 0xe975ec07bb5412aa => 88
	i64 16833383113903931215, ; 198: mscorlib => 0xe99c30c1484d7f4f => 8
	i64 17024911836938395553, ; 199: Xamarin.AndroidX.Annotation.Experimental.dll => 0xec44a31d250e5fa1 => 29
	i64 17037200463775726619, ; 200: Xamarin.AndroidX.Legacy.Support.Core.Utils => 0xec704b8e0a78fc1b => 56
	i64 17523180151706183041, ; 201: System.Json => 0xf32ed781959f6581 => 16
	i64 17704177640604968747, ; 202: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 63
	i64 17710060891934109755, ; 203: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 61
	i64 17751885584336325282, ; 204: System.Data.OleDb.dll => 0xf65b5de2abbe8aa2 => 12
	i64 17838668724098252521, ; 205: System.Buffers.dll => 0xf78faeb0f5bf3ee9 => 9
	i64 17891337867145587222, ; 206: Xamarin.Jetbrains.Annotations => 0xf84accff6fb52a16 => 83
	i64 17928294245072900555, ; 207: System.IO.Compression.FileSystem.dll => 0xf8ce18a0b24011cb => 91
	i64 18116111925905154859, ; 208: Xamarin.AndroidX.Arch.Core.Runtime => 0xfb695bd036cb632b => 35
	i64 18129453464017766560, ; 209: System.ServiceModel.Internals.dll => 0xfb98c1df1ec108a0 => 95
	i64 18146411883821974900, ; 210: System.Formats.Asn1.dll => 0xfbd50176eb22c574 => 14
	i64 18203743254473369877, ; 211: System.Security.Cryptography.Pkcs.dll => 0xfca0b00ad94c6915 => 23
	i64 18260797123374478311, ; 212: Xamarin.AndroidX.Emoji2 => 0xfd6b623bde35f3e7 => 52
	i64 18380184030268848184 ; 213: Xamarin.AndroidX.VersionedParcelable => 0xff1387fe3e7b7838 => 76
], align 8
@assembly_image_cache_indices = local_unnamed_addr constant [214 x i32] [
	i32 51, i32 7, i32 106, i32 38, i32 70, i32 39, i32 44, i32 0, ; 0..7
	i32 60, i32 89, i32 50, i32 96, i32 99, i32 80, i32 34, i32 94, ; 8..15
	i32 102, i32 31, i32 62, i32 56, i32 18, i32 17, i32 32, i32 70, ; 16..23
	i32 5, i32 28, i32 6, i32 61, i32 100, i32 65, i32 36, i32 86, ; 24..31
	i32 50, i32 97, i32 69, i32 58, i32 24, i32 21, i32 43, i32 74, ; 32..39
	i32 22, i32 27, i32 26, i32 8, i32 21, i32 71, i32 80, i32 57, ; 40..47
	i32 29, i32 20, i32 87, i32 72, i32 19, i32 22, i32 101, i32 1, ; 48..55
	i32 68, i32 51, i32 17, i32 44, i32 95, i32 76, i32 59, i32 27, ; 56..63
	i32 79, i32 64, i32 74, i32 4, i32 106, i32 73, i32 42, i32 10, ; 64..71
	i32 30, i32 78, i32 40, i32 104, i32 0, i32 14, i32 25, i32 60, ; 72..79
	i32 58, i32 6, i32 36, i32 47, i32 81, i32 97, i32 98, i32 20, ; 80..87
	i32 55, i32 23, i32 98, i32 79, i32 93, i32 84, i32 105, i32 11, ; 88..95
	i32 31, i32 105, i32 92, i32 57, i32 88, i32 3, i32 85, i32 101, ; 96..103
	i32 41, i32 59, i32 53, i32 73, i32 103, i32 3, i32 91, i32 67, ; 104..111
	i32 86, i32 2, i32 78, i32 32, i32 19, i32 43, i32 7, i32 40, ; 112..119
	i32 96, i32 53, i32 99, i32 93, i32 47, i32 83, i32 72, i32 87, ; 120..127
	i32 45, i32 5, i32 103, i32 34, i32 30, i32 10, i32 26, i32 81, ; 128..135
	i32 77, i32 33, i32 39, i32 46, i32 66, i32 15, i32 77, i32 28, ; 136..143
	i32 71, i32 1, i32 55, i32 18, i32 9, i32 75, i32 25, i32 15, ; 144..151
	i32 54, i32 63, i32 49, i32 37, i32 90, i32 38, i32 89, i32 48, ; 152..159
	i32 104, i32 52, i32 94, i32 75, i32 41, i32 82, i32 16, i32 84, ; 160..167
	i32 35, i32 68, i32 48, i32 11, i32 54, i32 4, i32 12, i32 37, ; 168..175
	i32 65, i32 66, i32 69, i32 24, i32 64, i32 82, i32 46, i32 90, ; 176..183
	i32 49, i32 67, i32 85, i32 45, i32 62, i32 13, i32 2, i32 102, ; 184..191
	i32 100, i32 13, i32 33, i32 92, i32 42, i32 88, i32 8, i32 29, ; 192..199
	i32 56, i32 16, i32 63, i32 61, i32 12, i32 9, i32 83, i32 91, ; 200..207
	i32 35, i32 95, i32 14, i32 23, i32 52, i32 76 ; 208..213
], align 4

@marshal_methods_number_of_classes = local_unnamed_addr constant i32 0, align 4

; marshal_methods_class_cache
@marshal_methods_class_cache = global [0 x %struct.MarshalMethodsManagedClass] [
], align 8; end of 'marshal_methods_class_cache' array


@get_function_pointer = internal unnamed_addr global void (i32, i32, i32, i8**)* null, align 8

; Function attributes: "frame-pointer"="non-leaf" "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" uwtable willreturn writeonly
define void @xamarin_app_init (void (i32, i32, i32, i8**)* %fn) local_unnamed_addr #0
{
	store void (i32, i32, i32, i8**)* %fn, void (i32, i32, i32, i8**)** @get_function_pointer, align 8
	ret void
}

; Names of classes in which marshal methods reside
@mm_class_names = local_unnamed_addr constant [0 x i8*] zeroinitializer, align 8
@__MarshalMethodName_name.0 = internal constant [1 x i8] c"\00", align 1

; mm_method_names
@mm_method_names = local_unnamed_addr constant [1 x %struct.MarshalMethodName] [
	; 0
	%struct.MarshalMethodName {
		i64 0, ; id 0x0; name: 
		i8* getelementptr inbounds ([1 x i8], [1 x i8]* @__MarshalMethodName_name.0, i32 0, i32 0); name
	}
], align 8; end of 'mm_method_names' array


attributes #0 = { "min-legal-vector-width"="0" mustprogress nofree norecurse nosync "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable willreturn writeonly "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #1 = { "min-legal-vector-width"="0" mustprogress "no-trapping-math"="true" nounwind sspstrong "stack-protector-buffer-size"="8" uwtable "frame-pointer"="non-leaf" "target-cpu"="generic" "target-features"="+neon,+outline-atomics" }
attributes #2 = { nounwind }

!llvm.module.flags = !{!0, !1, !2, !3, !4, !5}
!llvm.ident = !{!6}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"branch-target-enforcement", i32 0}
!3 = !{i32 1, !"sign-return-address", i32 0}
!4 = !{i32 1, !"sign-return-address-all", i32 0}
!5 = !{i32 1, !"sign-return-address-with-bkey", i32 0}
!6 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
!llvm.linker.options = !{}
