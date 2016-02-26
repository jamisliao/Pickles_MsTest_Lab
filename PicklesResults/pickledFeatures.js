jsonPWrapper ({
  "Features": [
    {
      "RelativeFolder": "結帳運費試算驗證.feature",
      "Feature": {
        "Name": "結帳運費試算驗證",
        "Description": "\t提供計算使用者的購物車運費",
        "FeatureElements": [
          {
            "Name": "VIP帳號，只有購買五本書籍",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "購物車中有",
                "TableArgument": {
                  "HeaderRow": [
                    "Name",
                    "ProductType",
                    "ProductSize"
                  ],
                  "DataRows": [
                    [
                      "C#",
                      "Book",
                      "Small"
                    ],
                    [
                      "SQL Server",
                      "Book",
                      "Small"
                    ],
                    [
                      "Node.js",
                      "Book",
                      "Small"
                    ],
                    [
                      "Asp.Net MVC",
                      "Book",
                      "Small"
                    ],
                    [
                      "JavaScript",
                      "Book",
                      "Small"
                    ]
                  ]
                }
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "使用者為 VipUser"
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "計算運費"
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "運費應為 0"
              }
            ],
            "Tags": [
              "@結帳運費試算驗證",
              "@VIP"
            ],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          },
          {
            "Name": "VIP帳號，購買五本書籍和一台家電",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "購物車中有",
                "TableArgument": {
                  "HeaderRow": [
                    "Name",
                    "ProductType",
                    "ProductSize"
                  ],
                  "DataRows": [
                    [
                      "C#",
                      "Book",
                      "Small"
                    ],
                    [
                      "SQL Server",
                      "Book",
                      "Small"
                    ],
                    [
                      "Node.js",
                      "Book",
                      "Small"
                    ],
                    [
                      "Asp.Net MVC",
                      "Book",
                      "Small"
                    ],
                    [
                      "JavaScript",
                      "Book",
                      "Small"
                    ],
                    [
                      "TV",
                      "Electronic",
                      "Big"
                    ]
                  ]
                }
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "使用者為 VipUser"
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "計算運費"
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "運費應為 300"
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          },
          {
            "Name": "VIP帳號，購買四本書籍",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "購物車中有",
                "TableArgument": {
                  "HeaderRow": [
                    "Name",
                    "ProductType",
                    "ProductSize"
                  ],
                  "DataRows": [
                    [
                      "C#",
                      "Book",
                      "Small"
                    ],
                    [
                      "SQL Server",
                      "Book",
                      "Small"
                    ],
                    [
                      "Node.js",
                      "Book",
                      "Small"
                    ],
                    [
                      "Asp.Net MVC",
                      "Book",
                      "Small"
                    ]
                  ]
                }
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "使用者為 VipUser"
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "計算運費"
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "運費應為 100"
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          },
          {
            "Name": "VIP帳號，購買一台筆記型電腦和一本書籍",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "購物車中有",
                "TableArgument": {
                  "HeaderRow": [
                    "Name",
                    "ProductType",
                    "ProductSize"
                  ],
                  "DataRows": [
                    [
                      "NetBook",
                      "Laptop",
                      "Medium"
                    ],
                    [
                      "C#",
                      "Book",
                      "Small"
                    ]
                  ]
                }
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "使用者為 VipUser"
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "計算運費"
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "運費應為 200"
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          },
          {
            "Name": "一般帳號，只有購買五本書籍",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "購物車中有",
                "TableArgument": {
                  "HeaderRow": [
                    "Name",
                    "ProductType",
                    "ProductSize"
                  ],
                  "DataRows": [
                    [
                      "C#",
                      "Book",
                      "Small"
                    ],
                    [
                      "SQL Server",
                      "Book",
                      "Small"
                    ],
                    [
                      "Node.js",
                      "Book",
                      "Small"
                    ],
                    [
                      "Asp.Net MVC",
                      "Book",
                      "Small"
                    ],
                    [
                      "JavaScript",
                      "Book",
                      "Small"
                    ]
                  ]
                }
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "使用者為 NormalUser"
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "計算運費"
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "運費應為 100"
              }
            ],
            "Tags": [
              "@一般帳號"
            ],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          },
          {
            "Name": "一般帳號帳號，購買四本書籍",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "購物車中有",
                "TableArgument": {
                  "HeaderRow": [
                    "Name",
                    "ProductType",
                    "ProductSize"
                  ],
                  "DataRows": [
                    [
                      "C#",
                      "Book",
                      "Small"
                    ],
                    [
                      "SQL Server",
                      "Book",
                      "Small"
                    ],
                    [
                      "Node.js",
                      "Book",
                      "Small"
                    ],
                    [
                      "Asp.Net MVC",
                      "Book",
                      "Small"
                    ]
                  ]
                }
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "使用者為 NormalUser"
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "計算運費"
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "運費應為 100"
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          },
          {
            "Name": "一般帳號帳號，購買五本書籍和一台家電",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "購物車中有",
                "TableArgument": {
                  "HeaderRow": [
                    "Name",
                    "ProductType",
                    "ProductSize"
                  ],
                  "DataRows": [
                    [
                      "C#",
                      "Book",
                      "Small"
                    ],
                    [
                      "SQL Server",
                      "Book",
                      "Small"
                    ],
                    [
                      "Node.js",
                      "Book",
                      "Small"
                    ],
                    [
                      "Asp.Net MVC",
                      "Book",
                      "Small"
                    ],
                    [
                      "JavaScript",
                      "Book",
                      "Small"
                    ],
                    [
                      "TV",
                      "Electronic",
                      "Big"
                    ]
                  ]
                }
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "使用者為 NormalUser"
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "計算運費"
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "運費應為 300"
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          },
          {
            "Name": "一般帳號帳號，購買一台筆記型電腦和一本書籍",
            "Description": "",
            "Steps": [
              {
                "Keyword": "Given",
                "NativeKeyword": "Given ",
                "Name": "購物車中有",
                "TableArgument": {
                  "HeaderRow": [
                    "Name",
                    "ProductType",
                    "ProductSize"
                  ],
                  "DataRows": [
                    [
                      "NetBook",
                      "Laptop",
                      "Medium"
                    ],
                    [
                      "C#",
                      "Book",
                      "Small"
                    ]
                  ]
                }
              },
              {
                "Keyword": "And",
                "NativeKeyword": "And ",
                "Name": "使用者為 NormalUser"
              },
              {
                "Keyword": "When",
                "NativeKeyword": "When ",
                "Name": "計算運費"
              },
              {
                "Keyword": "Then",
                "NativeKeyword": "Then ",
                "Name": "運費應為 200"
              }
            ],
            "Tags": [],
            "Result": {
              "WasExecuted": true,
              "WasSuccessful": true
            }
          }
        ],
        "Result": {
          "WasExecuted": true,
          "WasSuccessful": true
        },
        "Tags": []
      },
      "Result": {
        "WasExecuted": true,
        "WasSuccessful": true
      }
    }
  ],
  "Configuration": {
    "GeneratedOn": "25 二月 2016 20:24:10"
  }
});