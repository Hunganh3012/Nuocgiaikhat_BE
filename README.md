-----------------------------------ĐỒ ÁN WEBSITE BÁN HÀNG PHẦN BACKEND----------------------

-----CÔNG NGHỆ SỬ DỤNG: ASP.NET

-----CSDL: SQL SERVER



---------------------------------------------------------------Cấu trúc Phân tầng của DOTNET----------------------


-------Apllication
			|
			|
			|---->Disability.Api(Console Application)
			|			|
			|			|->Controller
			|			|->Authrozion
			|
			|---->Disability.Apllication(Class Library)
						|
						|->AutoMaper
						|->Implementation
						|		|-->Service.cs
						|
						|->Interface
						|		|--IService.cs
						|
						|->ViewModel
								|-->Dto.cs
-------Domain
			|
			|
			|---->Disability.Data(Class Library)			
			|			|
			|			|
			|			|--------->Entites
			|			|			|-->Kết nối DB.( tạo bảng )
			|			|
			|			|--------->Enum
			|			|
			|			|--------->IResponsitories
			|			|			|-->IResponsitory.cs
			|			|
			|			|--------->Model
			|						|
			|						|-->Tạo folder Api:Model để chứa các thuộc tính để filter.
			|						|		
			|						|
			|						|--> Lấy các thuộc tính của các cột hiển thị trong DB khi dùng store
			|			
			|->Disability.Ef(Class Library)
						|
						|
						|--------> Repositories
						|			|-> Respository.cs( kết nối với interface của IResponsitories.
						|
						|-------->DisabilityDbContext.cs
