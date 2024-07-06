; ModuleID = 'obj\Release\130\android\compressed_assemblies.arm64-v8a.ll'
source_filename = "obj\Release\130\android\compressed_assemblies.arm64-v8a.ll"
target datalayout = "e-m:e-i8:8:32-i16:16:32-i64:64-i128:128-n32:64-S128"
target triple = "aarch64-unknown-linux-android"


%struct.CompressedAssemblyDescriptor = type {
	i32,; uint32_t uncompressed_file_size
	i8,; bool loaded
	i8*; uint8_t* data
}

%struct.CompressedAssemblies = type {
	i32,; uint32_t count
	%struct.CompressedAssemblyDescriptor*; CompressedAssemblyDescriptor* descriptors
}
@__CompressedAssemblyDescriptor_data_0 = internal global [423424 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_1 = internal global [6841856 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_2 = internal global [168960 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_3 = internal global [928768 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_4 = internal global [8704 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_5 = internal global [1192448 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_6 = internal global [1650176 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_7 = internal global [124928 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_8 = internal global [14768 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_9 = internal global [103936 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_10 = internal global [6656 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_11 = internal global [113152 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_12 = internal global [1321472 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_13 = internal global [92160 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_14 = internal global [73216 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_15 = internal global [218112 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_16 = internal global [36864 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_17 = internal global [8192 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_18 = internal global [109568 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_19 = internal global [68096 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_20 = internal global [645120 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_21 = internal global [15296 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_22 = internal global [10752 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_23 = internal global [1322496 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_24 = internal global [844288 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_25 = internal global [72192 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_26 = internal global [328704 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_27 = internal global [18432 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_28 = internal global [77824 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_29 = internal global [245248 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_30 = internal global [9728 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_31 = internal global [41984 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_32 = internal global [201728 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_33 = internal global [17408 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_34 = internal global [17408 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_35 = internal global [29184 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_36 = internal global [37376 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_37 = internal global [14848 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_38 = internal global [26112 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_39 = internal global [104448 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_40 = internal global [77312 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_41 = internal global [23576 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_42 = internal global [153016 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_43 = internal global [2247600 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_44 = internal global [27064 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_45 = internal global [537528 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_46 = internal global [14776 x i8] zeroinitializer, align 1
@__CompressedAssemblyDescriptor_data_47 = internal global [2154496 x i8] zeroinitializer, align 1


; Compressed assembly data storage
@compressed_assembly_descriptors = internal global [48 x %struct.CompressedAssemblyDescriptor] [
	; 0
	%struct.CompressedAssemblyDescriptor {
		i32 423424, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([423424 x i8], [423424 x i8]* @__CompressedAssemblyDescriptor_data_0, i32 0, i32 0); data
	}, 
	; 1
	%struct.CompressedAssemblyDescriptor {
		i32 6841856, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([6841856 x i8], [6841856 x i8]* @__CompressedAssemblyDescriptor_data_1, i32 0, i32 0); data
	}, 
	; 2
	%struct.CompressedAssemblyDescriptor {
		i32 168960, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([168960 x i8], [168960 x i8]* @__CompressedAssemblyDescriptor_data_2, i32 0, i32 0); data
	}, 
	; 3
	%struct.CompressedAssemblyDescriptor {
		i32 928768, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([928768 x i8], [928768 x i8]* @__CompressedAssemblyDescriptor_data_3, i32 0, i32 0); data
	}, 
	; 4
	%struct.CompressedAssemblyDescriptor {
		i32 8704, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([8704 x i8], [8704 x i8]* @__CompressedAssemblyDescriptor_data_4, i32 0, i32 0); data
	}, 
	; 5
	%struct.CompressedAssemblyDescriptor {
		i32 1192448, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1192448 x i8], [1192448 x i8]* @__CompressedAssemblyDescriptor_data_5, i32 0, i32 0); data
	}, 
	; 6
	%struct.CompressedAssemblyDescriptor {
		i32 1650176, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1650176 x i8], [1650176 x i8]* @__CompressedAssemblyDescriptor_data_6, i32 0, i32 0); data
	}, 
	; 7
	%struct.CompressedAssemblyDescriptor {
		i32 124928, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([124928 x i8], [124928 x i8]* @__CompressedAssemblyDescriptor_data_7, i32 0, i32 0); data
	}, 
	; 8
	%struct.CompressedAssemblyDescriptor {
		i32 14768, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([14768 x i8], [14768 x i8]* @__CompressedAssemblyDescriptor_data_8, i32 0, i32 0); data
	}, 
	; 9
	%struct.CompressedAssemblyDescriptor {
		i32 103936, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([103936 x i8], [103936 x i8]* @__CompressedAssemblyDescriptor_data_9, i32 0, i32 0); data
	}, 
	; 10
	%struct.CompressedAssemblyDescriptor {
		i32 6656, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([6656 x i8], [6656 x i8]* @__CompressedAssemblyDescriptor_data_10, i32 0, i32 0); data
	}, 
	; 11
	%struct.CompressedAssemblyDescriptor {
		i32 113152, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([113152 x i8], [113152 x i8]* @__CompressedAssemblyDescriptor_data_11, i32 0, i32 0); data
	}, 
	; 12
	%struct.CompressedAssemblyDescriptor {
		i32 1321472, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1321472 x i8], [1321472 x i8]* @__CompressedAssemblyDescriptor_data_12, i32 0, i32 0); data
	}, 
	; 13
	%struct.CompressedAssemblyDescriptor {
		i32 92160, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([92160 x i8], [92160 x i8]* @__CompressedAssemblyDescriptor_data_13, i32 0, i32 0); data
	}, 
	; 14
	%struct.CompressedAssemblyDescriptor {
		i32 73216, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([73216 x i8], [73216 x i8]* @__CompressedAssemblyDescriptor_data_14, i32 0, i32 0); data
	}, 
	; 15
	%struct.CompressedAssemblyDescriptor {
		i32 218112, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([218112 x i8], [218112 x i8]* @__CompressedAssemblyDescriptor_data_15, i32 0, i32 0); data
	}, 
	; 16
	%struct.CompressedAssemblyDescriptor {
		i32 36864, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([36864 x i8], [36864 x i8]* @__CompressedAssemblyDescriptor_data_16, i32 0, i32 0); data
	}, 
	; 17
	%struct.CompressedAssemblyDescriptor {
		i32 8192, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([8192 x i8], [8192 x i8]* @__CompressedAssemblyDescriptor_data_17, i32 0, i32 0); data
	}, 
	; 18
	%struct.CompressedAssemblyDescriptor {
		i32 109568, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([109568 x i8], [109568 x i8]* @__CompressedAssemblyDescriptor_data_18, i32 0, i32 0); data
	}, 
	; 19
	%struct.CompressedAssemblyDescriptor {
		i32 68096, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([68096 x i8], [68096 x i8]* @__CompressedAssemblyDescriptor_data_19, i32 0, i32 0); data
	}, 
	; 20
	%struct.CompressedAssemblyDescriptor {
		i32 645120, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([645120 x i8], [645120 x i8]* @__CompressedAssemblyDescriptor_data_20, i32 0, i32 0); data
	}, 
	; 21
	%struct.CompressedAssemblyDescriptor {
		i32 15296, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([15296 x i8], [15296 x i8]* @__CompressedAssemblyDescriptor_data_21, i32 0, i32 0); data
	}, 
	; 22
	%struct.CompressedAssemblyDescriptor {
		i32 10752, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([10752 x i8], [10752 x i8]* @__CompressedAssemblyDescriptor_data_22, i32 0, i32 0); data
	}, 
	; 23
	%struct.CompressedAssemblyDescriptor {
		i32 1322496, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([1322496 x i8], [1322496 x i8]* @__CompressedAssemblyDescriptor_data_23, i32 0, i32 0); data
	}, 
	; 24
	%struct.CompressedAssemblyDescriptor {
		i32 844288, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([844288 x i8], [844288 x i8]* @__CompressedAssemblyDescriptor_data_24, i32 0, i32 0); data
	}, 
	; 25
	%struct.CompressedAssemblyDescriptor {
		i32 72192, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([72192 x i8], [72192 x i8]* @__CompressedAssemblyDescriptor_data_25, i32 0, i32 0); data
	}, 
	; 26
	%struct.CompressedAssemblyDescriptor {
		i32 328704, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([328704 x i8], [328704 x i8]* @__CompressedAssemblyDescriptor_data_26, i32 0, i32 0); data
	}, 
	; 27
	%struct.CompressedAssemblyDescriptor {
		i32 18432, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([18432 x i8], [18432 x i8]* @__CompressedAssemblyDescriptor_data_27, i32 0, i32 0); data
	}, 
	; 28
	%struct.CompressedAssemblyDescriptor {
		i32 77824, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([77824 x i8], [77824 x i8]* @__CompressedAssemblyDescriptor_data_28, i32 0, i32 0); data
	}, 
	; 29
	%struct.CompressedAssemblyDescriptor {
		i32 245248, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([245248 x i8], [245248 x i8]* @__CompressedAssemblyDescriptor_data_29, i32 0, i32 0); data
	}, 
	; 30
	%struct.CompressedAssemblyDescriptor {
		i32 9728, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([9728 x i8], [9728 x i8]* @__CompressedAssemblyDescriptor_data_30, i32 0, i32 0); data
	}, 
	; 31
	%struct.CompressedAssemblyDescriptor {
		i32 41984, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([41984 x i8], [41984 x i8]* @__CompressedAssemblyDescriptor_data_31, i32 0, i32 0); data
	}, 
	; 32
	%struct.CompressedAssemblyDescriptor {
		i32 201728, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([201728 x i8], [201728 x i8]* @__CompressedAssemblyDescriptor_data_32, i32 0, i32 0); data
	}, 
	; 33
	%struct.CompressedAssemblyDescriptor {
		i32 17408, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([17408 x i8], [17408 x i8]* @__CompressedAssemblyDescriptor_data_33, i32 0, i32 0); data
	}, 
	; 34
	%struct.CompressedAssemblyDescriptor {
		i32 17408, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([17408 x i8], [17408 x i8]* @__CompressedAssemblyDescriptor_data_34, i32 0, i32 0); data
	}, 
	; 35
	%struct.CompressedAssemblyDescriptor {
		i32 29184, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([29184 x i8], [29184 x i8]* @__CompressedAssemblyDescriptor_data_35, i32 0, i32 0); data
	}, 
	; 36
	%struct.CompressedAssemblyDescriptor {
		i32 37376, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([37376 x i8], [37376 x i8]* @__CompressedAssemblyDescriptor_data_36, i32 0, i32 0); data
	}, 
	; 37
	%struct.CompressedAssemblyDescriptor {
		i32 14848, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([14848 x i8], [14848 x i8]* @__CompressedAssemblyDescriptor_data_37, i32 0, i32 0); data
	}, 
	; 38
	%struct.CompressedAssemblyDescriptor {
		i32 26112, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([26112 x i8], [26112 x i8]* @__CompressedAssemblyDescriptor_data_38, i32 0, i32 0); data
	}, 
	; 39
	%struct.CompressedAssemblyDescriptor {
		i32 104448, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([104448 x i8], [104448 x i8]* @__CompressedAssemblyDescriptor_data_39, i32 0, i32 0); data
	}, 
	; 40
	%struct.CompressedAssemblyDescriptor {
		i32 77312, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([77312 x i8], [77312 x i8]* @__CompressedAssemblyDescriptor_data_40, i32 0, i32 0); data
	}, 
	; 41
	%struct.CompressedAssemblyDescriptor {
		i32 23576, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([23576 x i8], [23576 x i8]* @__CompressedAssemblyDescriptor_data_41, i32 0, i32 0); data
	}, 
	; 42
	%struct.CompressedAssemblyDescriptor {
		i32 153016, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([153016 x i8], [153016 x i8]* @__CompressedAssemblyDescriptor_data_42, i32 0, i32 0); data
	}, 
	; 43
	%struct.CompressedAssemblyDescriptor {
		i32 2247600, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([2247600 x i8], [2247600 x i8]* @__CompressedAssemblyDescriptor_data_43, i32 0, i32 0); data
	}, 
	; 44
	%struct.CompressedAssemblyDescriptor {
		i32 27064, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([27064 x i8], [27064 x i8]* @__CompressedAssemblyDescriptor_data_44, i32 0, i32 0); data
	}, 
	; 45
	%struct.CompressedAssemblyDescriptor {
		i32 537528, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([537528 x i8], [537528 x i8]* @__CompressedAssemblyDescriptor_data_45, i32 0, i32 0); data
	}, 
	; 46
	%struct.CompressedAssemblyDescriptor {
		i32 14776, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([14776 x i8], [14776 x i8]* @__CompressedAssemblyDescriptor_data_46, i32 0, i32 0); data
	}, 
	; 47
	%struct.CompressedAssemblyDescriptor {
		i32 2154496, ; uncompressed_file_size
		i8 0, ; loaded
		i8* getelementptr inbounds ([2154496 x i8], [2154496 x i8]* @__CompressedAssemblyDescriptor_data_47, i32 0, i32 0); data
	}
], align 8; end of 'compressed_assembly_descriptors' array


; compressed_assemblies
@compressed_assemblies = local_unnamed_addr global %struct.CompressedAssemblies {
	i32 48, ; count
	%struct.CompressedAssemblyDescriptor* getelementptr inbounds ([48 x %struct.CompressedAssemblyDescriptor], [48 x %struct.CompressedAssemblyDescriptor]* @compressed_assembly_descriptors, i32 0, i32 0); descriptors
}, align 8


!llvm.module.flags = !{!0, !1, !2, !3, !4, !5}
!llvm.ident = !{!6}
!0 = !{i32 1, !"wchar_size", i32 4}
!1 = !{i32 7, !"PIC Level", i32 2}
!2 = !{i32 1, !"branch-target-enforcement", i32 0}
!3 = !{i32 1, !"sign-return-address", i32 0}
!4 = !{i32 1, !"sign-return-address-all", i32 0}
!5 = !{i32 1, !"sign-return-address-with-bkey", i32 0}
!6 = !{!"Xamarin.Android remotes/origin/d17-5 @ 45b0e144f73b2c8747d8b5ec8cbd3b55beca67f0"}
