SELECT 아이디, 예정반납일, 연체여부 FROM 대출;
SELECT * FROM 회원.대출;
SELECT * FROM 회원.회원;
UPDATE 대출 SET 연체여부 = 'x' WHERE 아이디 IN ('admin','user');
SELECT 도서.고유번호, 도서.도서이름, 대출.아이디, 대출.대출일, 대출.예정반납일 , 대출.연체여부
FROM 도서, 대출 
WHERE 도서.고유번호 = 대출.고유번호;

update 회원
set 역할 = "alba"
where 아이디 = "kmk41187";
SELECT 도서.고유번호, 도서.도서이름, 도서.저자, 도서.출판사, 대출.대출번호, 회원.이름, 회원.아이디, 대출.대출일, 대출.예정반납일, 대출.연체여부 
FROM 대출 
INNER JOIN 회원 ON 대출.아이디 = 회원.아이디 
right outer JOIN 도서 ON 대출.고유번호 = 도서.고유번호;