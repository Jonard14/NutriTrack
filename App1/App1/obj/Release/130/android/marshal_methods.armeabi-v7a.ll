; ModuleID = 'obj\Release\130\android\marshal_methods.armeabi-v7a.ll'
source_filename = "obj\Release\130\android\marshal_methods.armeabi-v7a.ll"
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
@assembly_image_cache_hashes = local_unnamed_addr constant [96 x i32] [
	i32 34715100, ; 0: Xamarin.Google.Guava.ListenableFuture.dll => 0x211b5dc => 37
	i32 318968648, ; 1: Xamarin.AndroidX.Activity.dll => 0x13031348 => 21
	i32 321597661, ; 2: System.Numerics => 0x132b30dd => 15
	i32 342366114, ; 3: Xamarin.AndroidX.Lifecycle.Common => 0x146817a2 => 29
	i32 442521989, ; 4: Xamarin.Essentials => 0x1a605985 => 34
	i32 450948140, ; 5: Xamarin.AndroidX.Fragment.dll => 0x1ae0ec2c => 28
	i32 465846621, ; 6: mscorlib => 0x1bc4415d => 7
	i32 469710990, ; 7: System.dll => 0x1bff388e => 12
	i32 526420162, ; 8: System.Transactions.dll => 0x1f6088c2 => 45
	i32 548916678, ; 9: Microsoft.Bcl.AsyncInterfaces => 0x20b7cdc6 => 4
	i32 586578074, ; 10: MimeKit => 0x22f6789a => 5
	i32 627609679, ; 11: Xamarin.AndroidX.CustomView => 0x2568904f => 26
	i32 662205335, ; 12: System.Text.Encodings.Web.dll => 0x27787397 => 18
	i32 691348768, ; 13: Xamarin.KotlinX.Coroutines.Android.dll => 0x29352520 => 40
	i32 700284507, ; 14: Xamarin.Jetbrains.Annotations => 0x29bd7e5b => 38
	i32 709152836, ; 15: System.Security.Cryptography.Pkcs.dll => 0x2a44d044 => 17
	i32 709365442, ; 16: App1 => 0x2a480ec2 => 0
	i32 928116545, ; 17: Xamarin.Google.Guava.ListenableFuture => 0x3751ef41 => 37
	i32 967690846, ; 18: Xamarin.AndroidX.Lifecycle.Common.dll => 0x39adca5e => 29
	i32 1012816738, ; 19: Xamarin.AndroidX.SavedState.dll => 0x3c5e5b62 => 33
	i32 1031528504, ; 20: Xamarin.Google.ErrorProne.Annotations.dll => 0x3d7be038 => 36
	i32 1035644815, ; 21: Xamarin.AndroidX.AppCompat => 0x3dbaaf8f => 22
	i32 1052210849, ; 22: Xamarin.AndroidX.Lifecycle.ViewModel.dll => 0x3eb776a1 => 31
	i32 1084122840, ; 23: Xamarin.Kotlin.StdLib => 0x409e66d8 => 39
	i32 1098259244, ; 24: System => 0x41761b2c => 12
	i32 1264890200, ; 25: Xamarin.KotlinX.Coroutines.Core.dll => 0x4b64b158 => 41
	i32 1275534314, ; 26: Xamarin.KotlinX.Coroutines.Android => 0x4c071bea => 40
	i32 1293217323, ; 27: Xamarin.AndroidX.DrawerLayout.dll => 0x4d14ee2b => 27
	i32 1376866003, ; 28: Xamarin.AndroidX.SavedState => 0x52114ed3 => 33
	i32 1406073936, ; 29: Xamarin.AndroidX.CoordinatorLayout => 0x53cefc50 => 24
	i32 1411638395, ; 30: System.Runtime.CompilerServices.Unsafe => 0x5423e47b => 16
	i32 1452070440, ; 31: System.Formats.Asn1.dll => 0x568cd628 => 13
	i32 1597949149, ; 32: Xamarin.Google.ErrorProne.Annotations => 0x5f3ec4dd => 36
	i32 1622152042, ; 33: Xamarin.AndroidX.Loader.dll => 0x60b0136a => 32
	i32 1639515021, ; 34: System.Net.Http.dll => 0x61b9038d => 44
	i32 1658251792, ; 35: Xamarin.Google.Android.Material.dll => 0x62d6ea10 => 35
	i32 1729485958, ; 36: Xamarin.AndroidX.CardView.dll => 0x6715dc86 => 23
	i32 1733338956, ; 37: MailKit => 0x6750a74c => 3
	i32 1746115085, ; 38: System.IO.Pipelines.dll => 0x68139a0d => 14
	i32 1776026572, ; 39: System.Core.dll => 0x69dc03cc => 9
	i32 1788241197, ; 40: Xamarin.AndroidX.Fragment => 0x6a96652d => 28
	i32 1796167890, ; 41: Microsoft.Bcl.AsyncInterfaces.dll => 0x6b0f58d2 => 4
	i32 1808609942, ; 42: Xamarin.AndroidX.Loader => 0x6bcd3296 => 32
	i32 1813058853, ; 43: Xamarin.Kotlin.StdLib.dll => 0x6c111525 => 39
	i32 1813201214, ; 44: Xamarin.Google.Android.Material => 0x6c13413e => 35
	i32 1867746548, ; 45: Xamarin.Essentials.dll => 0x6f538cf4 => 34
	i32 2011961780, ; 46: System.Buffers.dll => 0x77ec19b4 => 8
	i32 2019465201, ; 47: Xamarin.AndroidX.Lifecycle.ViewModel => 0x785e97f1 => 31
	i32 2026931361, ; 48: MailKit.dll => 0x78d084a1 => 3
	i32 2055257422, ; 49: Xamarin.AndroidX.Lifecycle.LiveData.Core.dll => 0x7a80bd4e => 30
	i32 2142278582, ; 50: System.Data.OleDb.dll => 0x7fb093b6 => 11
	i32 2201107256, ; 51: Xamarin.KotlinX.Coroutines.Core.Jvm.dll => 0x83323b38 => 42
	i32 2201231467, ; 52: System.Net.Http => 0x8334206b => 44
	i32 2475788418, ; 53: Java.Interop.dll => 0x93918882 => 2
	i32 2498657740, ; 54: BouncyCastle.Cryptography.dll => 0x94ee7dcc => 1
	i32 2501346920, ; 55: System.Data.DataSetExtensions => 0x95178668 => 43
	i32 2570120770, ; 56: System.Text.Encodings.Web => 0x9930ee42 => 18
	i32 2605712449, ; 57: Xamarin.KotlinX.Coroutines.Core.Jvm => 0x9b500441 => 42
	i32 2671474046, ; 58: Xamarin.KotlinX.Coroutines.Core => 0x9f3b757e => 41
	i32 2732626843, ; 59: Xamarin.AndroidX.Activity => 0xa2e0939b => 21
	i32 2736590120, ; 60: System.Data.OleDb => 0xa31d0d28 => 11
	i32 2770495804, ; 61: Xamarin.Jetbrains.Annotations.dll => 0xa522693c => 38
	i32 2810250172, ; 62: Xamarin.AndroidX.CoordinatorLayout.dll => 0xa78103bc => 24
	i32 2819470561, ; 63: System.Xml.dll => 0xa80db4e1 => 20
	i32 2905242038, ; 64: mscorlib.dll => 0xad2a79b6 => 7
	i32 2978675010, ; 65: Xamarin.AndroidX.DrawerLayout => 0xb18af942 => 27
	i32 3103600923, ; 66: System.Formats.Asn1 => 0xb8fd311b => 13
	i32 3124832203, ; 67: System.Threading.Tasks.Extensions => 0xba4127cb => 47
	i32 3171180504, ; 68: MimeKit.dll => 0xbd045fd8 => 5
	i32 3204380047, ; 69: System.Data.dll => 0xbefef58f => 10
	i32 3247949154, ; 70: Mono.Security => 0xc197c562 => 46
	i32 3258312781, ; 71: Xamarin.AndroidX.CardView => 0xc235e84d => 23
	i32 3265893370, ; 72: System.Threading.Tasks.Extensions.dll => 0xc2a993fa => 47
	i32 3317135071, ; 73: Xamarin.AndroidX.CustomView.dll => 0xc5b776df => 26
	i32 3317144872, ; 74: System.Data => 0xc5b79d28 => 10
	i32 3358260929, ; 75: System.Text.Json => 0xc82afec1 => 19
	i32 3362522851, ; 76: Xamarin.AndroidX.Core => 0xc86c06e3 => 25
	i32 3366347497, ; 77: Java.Interop => 0xc8a662e9 => 2
	i32 3395150330, ; 78: System.Runtime.CompilerServices.Unsafe.dll => 0xca5de1fa => 16
	i32 3414721009, ; 79: App1.dll => 0xcb8881f1 => 0
	i32 3429136800, ; 80: System.Xml => 0xcc6479a0 => 20
	i32 3476120550, ; 81: Mono.Android => 0xcf3163e6 => 6
	i32 3485117614, ; 82: System.Text.Json.dll => 0xcfbaacae => 19
	i32 3486566296, ; 83: System.Transactions => 0xcfd0c798 => 45
	i32 3605570793, ; 84: BouncyCastle.Cryptography => 0xd6e8a4e9 => 1
	i32 3641597786, ; 85: Xamarin.AndroidX.Lifecycle.LiveData.Core => 0xd90e5f5a => 30
	i32 3672681054, ; 86: Mono.Android.dll => 0xdae8aa5e => 6
	i32 3807198597, ; 87: System.Security.Cryptography.Pkcs => 0xe2ed3d85 => 17
	i32 3829621856, ; 88: System.Numerics.dll => 0xe4436460 => 15
	i32 3896760992, ; 89: Xamarin.AndroidX.Core.dll => 0xe843daa0 => 25
	i32 3945713374, ; 90: System.Data.DataSetExtensions.dll => 0xeb2ecede => 43
	i32 3955647286, ; 91: Xamarin.AndroidX.AppCompat.dll => 0xebc66336 => 22
	i32 4023392905, ; 92: System.IO.Pipelines => 0xefd01a89 => 14
	i32 4105002889, ; 93: Mono.Security.dll => 0xf4ad5f89 => 46
	i32 4151237749, ; 94: System.Core => 0xf76edc75 => 9
	i32 4260525087 ; 95: System.Buffers => 0xfdf2741f => 8
], align 4
@assembly_image_cache_indices = local_unnamed_addr constant [96 x i32] [
	i32 37, i32 21, i32 15, i32 29, i32 34, i32 28, i32 7, i32 12, ; 0..7
	i32 45, i32 4, i32 5, i32 26, i32 18, i32 40, i32 38, i32 17, ; 8..15
	i32 0, i32 37, i32 29, i32 33, i32 36, i32 22, i32 31, i32 39, ; 16..23
	i32 12, i32 41, i32 40, i32 27, i32 33, i32 24, i32 16, i32 13, ; 24..31
	i32 36, i32 32, i32 44, i32 35, i32 23, i32 3, i32 14, i32 9, ; 32..39
	i32 28, i32 4, i32 32, i32 39, i32 35, i32 34, i32 8, i32 31, ; 40..47
	i32 3, i32 30, i32 11, i32 42, i32 44, i32 2, i32 1, i32 43, ; 48..55
	i32 18, i32 42, i32 41, i32 21, i32 11, i32 38, i32 24, i32 20, ; 56..63
	i32 7, i32 27, i32 13, i32 47, i32 5, i32 10, i32 46, i32 23, ; 64..71
	i32 47, i32 26, i32 10, i32 19, i32 25, i32 2, i32 16, i32 0, ; 72..79
	i32 20, i32 6, i32 19, i32 45, i32 1, i32 30, i32 6, i32 17, ; 80..87
	i32 15, i32 25, i32 43, i32 22, i32 14, i32 46, i32 9, i32 8 ; 96..95
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
