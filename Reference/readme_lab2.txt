1.1 Tạo Dict	ok
**Thống kê monophone: tool không hỗ trợ tạo 2 file này.
1.2 Tạo Promts	ok
**1.3 Tạo Words.mlf
Vấn đề: Bị một số lỗi o thành e. Ví dụ như chữ học thì thành HOJC nhưng trong words.mlf lại thành HEJC. Khi dùng lệnh HLEd để tạo phones0.mlf sẽ báo lỗi.
Cách sửa: replace các từ sau trong words.mlf
EJC --> OJC	(học)
VIEOJC --> VIEEJC	(việc)
TREJNG --> TROJNG	(trọng)
NEJ --> NOJ

**1.4 Tạo phones
Vấn đề: tool không chỉnh lại đường dẫn nên file tạo ra là của dữ liệu mặc định (sn0035).
Cách sửa: không dùng tool, chạy dòng lệnh để tạo file phone0.mlf và phone1.mlf.
HLEd -l * -d dict -i phones0.mlf mkphone0.led words.mlf
HLEd -l * -d dict -i phones1.mlf mkphone1.led words.mlf

**1.5 Tạo mfc.scp
Vấn đề: tên file mfcc ở cột thứ 2 vẫn sử dụng tên mặc định (K22_SV35).
Cách sửa: replace chuỗi.

**1.6 Tạo train.scp
Vấn đề: tên file mfcc vẫn sử dụng tên mặc định (K22_SV35).
Cách sửa: replace chuỗi.

1.7 Tạo các thư mục	ok