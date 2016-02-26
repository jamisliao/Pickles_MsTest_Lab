Feature: 結帳運費試算驗證
	提供計算使用者的購物車運費

@結帳運費試算驗證
@VIP
Scenario: VIP帳號，只有購買五本書籍
	Given 購物車中有
	| Name        | ProductType | ProductSize |
	| C#          | Book        | Small       |
	| SQL Server  | Book        | Small       |
	| Node.js     | Book        | Small       |
	| Asp.Net MVC | Book        | Small       |
	| JavaScript  | Book        | Small       |
	And 使用者為 VipUser
	When 計算運費
	Then 運費應為 0

Scenario: VIP帳號，購買五本書籍和一台家電
	Given 購物車中有
	| Name        | ProductType | ProductSize |
	| C#          | Book        | Small       |
	| SQL Server  | Book        | Small       |
	| Node.js     | Book        | Small       |
	| Asp.Net MVC | Book        | Small       |
	| JavaScript  | Book        | Small       |
	| TV          | Electronic  | Big         |
	And 使用者為 VipUser
	When 計算運費
	Then 運費應為 300

Scenario: VIP帳號，購買四本書籍
	Given 購物車中有
	| Name        | ProductType | ProductSize |
	| C#          | Book        | Small       |
	| SQL Server  | Book        | Small       |
	| Node.js     | Book        | Small       |
	| Asp.Net MVC | Book        | Small       |
	And 使用者為 VipUser
	When 計算運費
	Then 運費應為 100

Scenario: VIP帳號，購買一台筆記型電腦和一本書籍
	Given 購物車中有
	| Name    | ProductType | ProductSize |
	| NetBook | Laptop      | Medium      |
	| C#      | Book        | Small       |
	And 使用者為 VipUser
	When 計算運費
	Then 運費應為 200

@一般帳號
Scenario: 一般帳號，只有購買五本書籍
	Given 購物車中有
	| Name        | ProductType | ProductSize |
	| C#          | Book        | Small       |
	| SQL Server  | Book        | Small       |
	| Node.js     | Book        | Small       |
	| Asp.Net MVC | Book        | Small       |
	| JavaScript  | Book        | Small       |
	And 使用者為 NormalUser
	When 計算運費
	Then 運費應為 100

Scenario: 一般帳號帳號，購買四本書籍
	Given 購物車中有
	| Name        | ProductType | ProductSize |
	| C#          | Book        | Small       |
	| SQL Server  | Book        | Small       |
	| Node.js     | Book        | Small       |
	| Asp.Net MVC | Book        | Small       |
	And 使用者為 NormalUser
	When 計算運費
	Then 運費應為 100

Scenario: 一般帳號帳號，購買五本書籍和一台家電
	Given 購物車中有
	| Name        | ProductType | ProductSize |
	| C#          | Book        | Small       |
	| SQL Server  | Book        | Small       |
	| Node.js     | Book        | Small       |
	| Asp.Net MVC | Book        | Small       |
	| JavaScript  | Book        | Small       |
	| TV          | Electronic  | Big         |
	And 使用者為 NormalUser
	When 計算運費
	Then 運費應為 300

Scenario: 一般帳號帳號，購買一台筆記型電腦和一本書籍
	Given 購物車中有
	| Name    | ProductType | ProductSize |
	| NetBook | Laptop      | Medium      |
	| C#      | Book        | Small       |
	And 使用者為 NormalUser
	When 計算運費
	Then 運費應為 200