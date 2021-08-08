# developer-community

### 필요 작업(생각나는대로 메모 후 구체화 해 나갈것)
- DB설계
- 화면구성
- 컴포넌트 프로젝트 생성
- 현재 생성된 프로젝트 확인
- 소스트리 다운로드 후 Git 연동
- Entity 스케폴딩 사용시 DB 관계설정
- 페이징 처리
- CRUD

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

