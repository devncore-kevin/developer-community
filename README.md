# developer-community

### 필요 작업(생각나는대로 메모 후 구체화 해 나갈것)
- DB설계
- 화면구성
- 컴포넌트 프로젝트 생성
- 현재 생성된 프로젝트 확인
- 소스트리 다운로드 후 Git 연동.
- Entity 스케폴딩 사용시 DB 관계설정.
- 페이징 처리.
- CRUD.

### CRUD 진행중 오류 사항
**MSSQL Primary Key 자동증가 IDENTITY Insert시 오류**  

```C#
   at Microsoft.EntityFrameworkCore.Update.ReaderModificationCommandBatch.Execute(IRelationalConnection connection)
   at Microsoft.EntityFrameworkCore.Update.Internal.BatchExecutor.Execute(IEnumerable`1 commandBatches, IRelationalConnection connection)
   at Microsoft.EntityFrameworkCore.Storage.RelationalDatabase.SaveChanges(IList`1 entries)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChanges(IList`1 entriesToSave)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChanges(DbContext _, Boolean acceptAllChangesOnSuccess)
   at Microsoft.EntityFrameworkCore.SqlServer.Storage.Internal.SqlServerExecutionStrategy.Execute[TState,TResult](TState state, Func`3 operation, Func`3 verifySucceeded)
   at Microsoft.EntityFrameworkCore.ChangeTracking.Internal.StateManager.SaveChanges(Boolean acceptAllChangesOnSuccess)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChanges(Boolean acceptAllChangesOnSuccess)
   at Microsoft.EntityFrameworkCore.DbContext.SaveChanges()
   at Dev_Community.Data.BoardService.<Add>d__1.MoveNext() in C:\devops\Dev-Community\Dev-Community\Data\DBConnection\BoardService.cs:line 21
```

```C#
 public partial class Board
    {
        public int Seq { get; set; }
        public int FkUserSeq { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; }
        public DateTime Created { get; set; }
        public DateTime Updated { get; set; }
    }
```

Add 후 SaveChanged() 메서드 실행시 오류가 나는데    
Entity Framework 스캐폴딩으로 만들어진 모델 Board 클래스를 사용해 Insert를 하려할 때    
int Seq(Key) 값이 0이 할당 되어 임의로 마지막 행의 Seq값에 1을 더한값을 넣어준 후 Insert를 했음    
= 당연히 실패 자동증가 값에 값을 할당 하면 안됨    

검색 후   

```C#
[Key]
[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
public int Seq { get; set; }
```

두줄을 추가 한 후에도 실패 했다.    

Context에 seq자동증가    

```C#
 modelBuilder.Entity<Board>()
               .Property(p => p.Seq)
               .ValueGeneratedOnAdd();
```

마크다운 텍스트 위 line 


