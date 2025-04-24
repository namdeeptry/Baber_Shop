namespace API.IRepository
{
    public interface IRepository<T> where T : class
    {
        // Các phương thức cơ bản cho các Reponsitory
        // 1. LIST: Lấy danh sách tất cả các đối tượng
        // 2. GET: Lấy một đối tượng theo id
        // 3. ADD: Thêm một đối tượng mới
        // 4. DELETE: Xóa một đối tượng theo id
        // 5. UPDATE: Cập nhật một đối tượng theo id

        Task<List<T>> LIST();
        Task<T> GET(int id);
        Task ADD(T item);
        Task DELETE(int id);
        Task UPDATE(T item,int id);

        //  Triển khai các Reponsitory khác theo cách triển khai của IReponsitory 




    }
}
