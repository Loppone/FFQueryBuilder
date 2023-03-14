namespace FFQueryBuilder.Repository
{
    public interface IReadableRepository : IContext
    {
        /// <summary>
        /// Torna un record
        /// </summary>
        /// <returns></returns>
        dynamic GetById(object id);
    }
}
