SELECT * FROM 도서;
update 회원
set 역할 = "alba"
where 아이디 = "kmk41187";
SELECT 도서.고유번호, 도서.도서이름, 도서.저자, 도서.출판사, 대출.대출번호, 회원.이름, 회원.아이디, 대출.대출일, 대출.예정반납일 
FROM 대출 
INNER JOIN 회원 ON 대출.아이디 = 회원.아이디 
right outer JOIN 도서 ON 대출.고유번호 = 도서.고유번호;