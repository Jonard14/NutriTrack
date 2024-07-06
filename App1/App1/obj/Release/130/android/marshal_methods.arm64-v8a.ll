; ModuleID = 'obj\Release\130\android\marshal_methods.arm64-v8a.ll'
source_filename = "obj\Release\130\android\marshal_methods.arm64-v8a.ll"
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
@assembly_image_cache_hashes = local_unnamed_addr constant [96 x i64] [
	i64 120698629574877762, ; 0: Mono.Android => 0x1accec39cafe242 => 6
	i64 232391251801502327, ; 1: Xamarin.AndroidX.SavedState.dll => 0x3399e9cbc897277 => 33
	i64 456145817121827372, ; 2: App1.dll => 0x6548e343353aa2c => 0
	i64 872800313462103108, ; 3: Xamarin.AndroidX.DrawerLayout => 0xc1ccf42c3c21c44 => 27
	i64 940822596282819491, ; 4: System.Transactions => 0xd0e792aa81923a3 => 45
	i64 1000557547492888992, ; 5: Mono.Security.dll => 0xde2b1c9cba651a0 => 46
	i64 1120440138749646132, ; 6: Xamarin.Google.Android.Material.dll => 0xf8c9a5eae431534 => 35
	i64 1795316252682057001, ; 7: Xamarin.AndroidX.AppCompat.dll => 0x18ea3e9eac997529 => 22
	i64 1836611346387731153, ; 8: Xamarin.AndroidX.SavedState => 0x197cf449ebe482d1 => 33
	i64 1865037103900624886, ; 9: Microsoft.Bcl.AsyncInterfaces => 0x19e1f15d56eb87f6 => 4
	i64 1963507636676687784, ; 10: MimeKit => 0x1b3fc7cadde177a8 => 5
	i64 1981742497975770890, ; 11: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x1b80904d5c241f0a => 31
	i64 2040001226662520565, ; 12: System.Threading.Tasks.Extensions.dll => 0x1c4f8a4ea894a6f5 => 47
	i64 2203565783020068373, ; 13: Xamarin.KotlinX.Coroutines.Core => 0x1e94a367981dde15 => 41
	i64 2262844636196693701, ; 14: Xamarin.AndroidX.DrawerLayout.dll => 0x1f673d352266e6c5 => 27
	i64 2329709569556905518, ; 15: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x2054ca829b447e2e => 30
	i64 2335503487726329082, ; 16: System.Text.Encodings.Web => 0x2069600c4d9d1cfa => 18
	i64 2337758774805907496, ; 17: System.Runtime.CompilerServices.Unsafe => 0x207163383edbc828 => 16
	i64 2470498323731680442, ; 18: Xamarin.AndroidX.CoordinatorLayout => 0x2248f922dc398cba => 24
	i64 2547086958574651984, ; 19: Xamarin.AndroidX.Activity.dll => 0x2359121801df4a50 => 21
	i64 2592350477072141967, ; 20: System.Xml.dll => 0x23f9e10627330e8f => 20
	i64 2624866290265602282, ; 21: mscorlib.dll => 0x246d65fbde2db8ea => 7
	i64 2783046991838674048, ; 22: System.Runtime.CompilerServices.Unsafe.dll => 0x269f5e7e6dc37c80 => 16
	i64 3017704767998173186, ; 23: Xamarin.Google.Android.Material => 0x29e10a7f7d88a002 => 35
	i64 3289520064315143713, ; 24: Xamarin.AndroidX.Lifecycle.Common => 0x2da6b911e3063621 => 29
	i64 3344514922410554693, ; 25: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x2e6a1a9a18463545 => 42
	i64 3531994851595924923, ; 26: System.Numerics => 0x31042a9aade235bb => 15
	i64 4794310189461587505, ; 27: Xamarin.AndroidX.Activity => 0x4288cfb749e4c631 => 21
	i64 5203618020066742981, ; 28: Xamarin.Essentials => 0x4836f704f0e652c5 => 34
	i64 5382384903084550500, ; 29: MailKit.dll => 0x4ab2128d60c7a964 => 3
	i64 5507995362134886206, ; 30: System.Core.dll => 0x4c705499688c873e => 9
	i64 5917160574407189813, ; 31: App1 => 0x521dfa31247ca535 => 0
	i64 5979151488806146654, ; 32: System.Formats.Asn1 => 0x52fa3699a489d25e => 13
	i64 6222399776351216807, ; 33: System.Text.Json.dll => 0x565a67a0ffe264a7 => 19
	i64 6401687960814735282, ; 34: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0x58d75d486341cfb2 => 30
	i64 6433271170595107064, ; 35: MimeKit.dll => 0x5947920b731530f8 => 5
	i64 6548213210057960872, ; 36: Xamarin.AndroidX.CustomView.dll => 0x5adfed387b066da8 => 26
	i64 6589202984700901502, ; 37: Xamarin.Google.ErrorProne.Annotations.dll => 0x5b718d34180a787e => 36
	i64 7105430439328552570, ; 38: System.Security.Cryptography.Pkcs => 0x629b8f56a06d167a => 17
	i64 7637365915383206639, ; 39: Xamarin.Essentials.dll => 0x69fd5fd5e61792ef => 34
	i64 7654504624184590948, ; 40: System.Net.Http => 0x6a3a4366801b8264 => 44
	i64 7735352534559001595, ; 41: Xamarin.Kotlin.StdLib.dll => 0x6b597e2582ce8bfb => 39
	i64 7820441508502274321, ; 42: System.Data => 0x6c87ca1e14ff8111 => 10
	i64 8083354569033831015, ; 43: Xamarin.AndroidX.Lifecycle.Common.dll => 0x702dd82730cad267 => 29
	i64 8103644804370223335, ; 44: System.Data.DataSetExtensions.dll => 0x7075ee03be6d50e7 => 43
	i64 8167236081217502503, ; 45: Java.Interop.dll => 0x7157d9f1a9b8fd27 => 2
	i64 8187640529827139739, ; 46: Xamarin.KotlinX.Coroutines.Android => 0x71a057ae90f0109b => 40
	i64 8626175481042262068, ; 47: Java.Interop => 0x77b654e585b55834 => 2
	i64 9031035476476434958, ; 48: Xamarin.KotlinX.Coroutines.Core.dll => 0x7d54aeead9541a0e => 41
	i64 9286073997824813334, ; 49: BouncyCastle.Cryptography => 0x80dec319ee56e916 => 1
	i64 9324707631942237306, ; 50: Xamarin.AndroidX.AppCompat => 0x8168042fd44a7c7a => 22
	i64 9662334977499516867, ; 51: System.Numerics.dll => 0x8617827802b0cfc3 => 15
	i64 9678050649315576968, ; 52: Xamarin.AndroidX.CoordinatorLayout.dll => 0x864f57c9feb18c88 => 24
	i64 9808709177481450983, ; 53: Mono.Android.dll => 0x881f890734e555e7 => 6
	i64 9834056768316610435, ; 54: System.Transactions.dll => 0x8879968718899783 => 45
	i64 9998632235833408227, ; 55: Mono.Security => 0x8ac2470b209ebae3 => 46
	i64 10038780035334861115, ; 56: System.Net.Http.dll => 0x8b50e941206af13b => 44
	i64 10229024438826829339, ; 57: Xamarin.AndroidX.CustomView => 0x8df4cb880b10061b => 26
	i64 10321854143672141184, ; 58: Xamarin.Jetbrains.Annotations.dll => 0x8f3e97a7f8f8c580 => 38
	i64 10406448008575299332, ; 59: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x906b2153fcb3af04 => 42
	i64 10430153318873392755, ; 60: Xamarin.AndroidX.Core => 0x90bf592ea44f6673 => 25
	i64 10447083246144586668, ; 61: Microsoft.Bcl.AsyncInterfaces.dll => 0x90fb7edc816203ac => 4
	i64 11023048688141570732, ; 62: System.Core => 0x98f9bc61168392ac => 9
	i64 11037814507248023548, ; 63: System.Xml => 0x992e31d0412bf7fc => 20
	i64 11071824625609515081, ; 64: Xamarin.Google.ErrorProne.Annotations => 0x99a705d600e0a049 => 36
	i64 11513602507638267977, ; 65: System.IO.Pipelines.dll => 0x9fc8887aa0d36049 => 14
	i64 12102847907131387746, ; 66: System.Buffers => 0xa7f5f40c43256f62 => 8
	i64 12145679461940342714, ; 67: System.Text.Json => 0xa88e1f1ebcb62fba => 19
	i64 12313367145828839434, ; 68: System.IO.Pipelines => 0xaae1de2e1c17f00a => 14
	i64 12451044538927396471, ; 69: Xamarin.AndroidX.Fragment.dll => 0xaccaff0a2955b677 => 28
	i64 12466513435562512481, ; 70: Xamarin.AndroidX.Loader.dll => 0xad01f3eb52569061 => 32
	i64 12538491095302438457, ; 71: Xamarin.AndroidX.CardView.dll => 0xae01ab382ae67e39 => 23
	i64 13454009404024712428, ; 72: Xamarin.Google.Guava.ListenableFuture => 0xbab63e4543a86cec => 37
	i64 13465488254036897740, ; 73: Xamarin.Kotlin.StdLib => 0xbadf06394d106fcc => 39
	i64 13647894001087880694, ; 74: System.Data.dll => 0xbd670f48cb071df6 => 10
	i64 13959074834287824816, ; 75: Xamarin.AndroidX.Fragment => 0xc1b8989a7ad20fb0 => 28
	i64 13961013029440053076, ; 76: MailKit => 0xc1bf7b61b45fdf54 => 3
	i64 14109164557138018902, ; 77: System.Data.OleDb => 0xc3cdd26941be4256 => 11
	i64 14124974489674258913, ; 78: Xamarin.AndroidX.CardView => 0xc405fd76067d19e1 => 23
	i64 14551742072151931844, ; 79: System.Text.Encodings.Web.dll => 0xc9f22c50f1b8fbc4 => 18
	i64 14792063746108907174, ; 80: Xamarin.Google.Guava.ListenableFuture.dll => 0xcd47f79af9c15ea6 => 37
	i64 15279429628684179188, ; 81: Xamarin.KotlinX.Coroutines.Android.dll => 0xd40b704b1c4c96f4 => 40
	i64 15370334346939861994, ; 82: Xamarin.AndroidX.Core.dll => 0xd54e65a72c560bea => 25
	i64 15609085926864131306, ; 83: System.dll => 0xd89e9cf3334914ea => 12
	i64 15620612276725577442, ; 84: BouncyCastle.Cryptography.dll => 0xd8c7901aa85576e2 => 1
	i64 15963349826457351533, ; 85: System.Threading.Tasks.Extensions => 0xdd893616f748b56d => 47
	i64 16154507427712707110, ; 86: System => 0xe03056ea4e39aa26 => 12
	i64 16822611501064131242, ; 87: System.Data.DataSetExtensions => 0xe975ec07bb5412aa => 43
	i64 16833383113903931215, ; 88: mscorlib => 0xe99c30c1484d7f4f => 7
	i64 17704177640604968747, ; 89: Xamarin.AndroidX.Loader => 0xf5b1dfc36cac272b => 32
	i64 17710060891934109755, ; 90: Xamarin.AndroidX.Lifecycle.ViewModel => 0xf5c6c68c9e45303b => 31
	i64 17751885584336325282, ; 91: System.Data.OleDb.dll => 0xf65b5de2abbe8aa2 => 11
	i64 17838668724098252521, ; 92: System.Buffers.dll => 0xf78faeb0f5bf3ee9 => 8
	i64 17891337867145587222, ; 93: Xamarin.Jetbrains.Annotations => 0xf84accff6fb52a16 => 38
	i64 18146411883821974900, ; 94: System.Formats.Asn1.dll => 0xfbd50176eb22c574 => 13
	i64 18203743254473369877 ; 95: System.Security.Cryptography.Pkcs.dll => 0xfca0b00ad94c6915 => 17
], align 8
@assembly_image_cache_indices = local_unnamed_addr constant [96 x i32] [
	i32 6, i32 33, i32 0, i32 27, i32 45, i32 46, i32 35, i32 22, ; 0..7
	i32 33, i32 4, i32 5, i32 31, i32 47, i32 41, i32 27, i32 30, ; 8..15
	i32 18, i32 16, i32 24, i32 21, i32 20, i32 7, i32 16, i32 35, ; 16..23
	i32 29, i32 42, i32 15, i32 21, i32 34, i32 3, i32 9, i32 0, ; 24..31
	i32 13, i32 19, i32 30, i32 5, i32 26, i32 36, i32 17, i32 34, ; 32..39
	i32 44, i32 39, i32 10, i32 29, i32 43, i32 2, i32 40, i32 2, ; 40..47
	i32 41, i32 1, i32 22, i32 15, i32 24, i32 6, i32 45, i32 46, ; 48..55
	i32 44, i32 26, i32 38, i32 42, i32 25, i32 4, i32 9, i32 20, ; 56..63
	i32 36, i32 14, i32 8, i32 19, i32 14, i32 28, i32 32, i32 23, ; 64..71
	i32 37, i32 39, i32 10, i32 28, i32 3, i32 11, i32 23, i32 18, ; 72..79
	i32 37, i32 40, i32 25, i32 12, i32 1, i32 47, i32 12, i32 43, ; 80..87
	i32 7, i32 32, i32 31, i32 11, i32 8, i32 38, i32 13, i32 17 ; 96..95
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
