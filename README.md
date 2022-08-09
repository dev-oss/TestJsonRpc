# TestJsonRpc


## ➤ Test usage

1. Run TestJsonRpc.exe (F5 from within Visual Studio)
2. Run Postman program (you can get it here https://www.postman.com/downloads/)
3. Perform a POST request to URL http://localhost:7147/OilPrices with JSON body like the following (change start and end dates as you prefer):

{ 
"id": 1, 
"jsonrpc": "2.0", 
"method": "GetOilPriceTrend", 
"params": { 
"startDateISO8601": "2020-01-01", 
"endDateISO8601": "2020-01-02" 
} 
} 
