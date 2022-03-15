namespace SimpleX.Maze
{
    public static class MazeProvider
    {
        // ���������Թ�
        public static RectangleMazeField CreateRectangleMaze(int width, int height)
        {
            RectangleMaze maze = new RectangleMaze(width, height);
            return maze.Create();
        }

        // �����з���ľ����Թ���������
        public static RectangleMazeField CreateRectangleDungeon(int width, int height, int minRoomWidth, int maxRoomWidth, int minRoomHeight, int maxRoomHeight, int maxRoomCount)
        {
            RectangleDungeon dungeon = new RectangleDungeon(width, height, minRoomWidth, maxRoomWidth, minRoomHeight, maxRoomHeight, maxRoomCount);
            return dungeon.Create();
        }
    }
}