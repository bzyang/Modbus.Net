﻿namespace Modbus.Net
{
    /// <summary>
    ///     协议转换的接口
    /// </summary>
    public interface IProtocalFormatting
    {
        /// <summary>
        ///     从输入结构格式化
        /// </summary>
        /// <param name="message">结构化的输入数据</param>
        /// <returns>格式化后的字节流</returns>
        byte[] Format(IInputStruct message);

        /// <summary>
        ///     从对象的参数数组格式化
        /// </summary>
        /// <param name="message">非结构化的输入数据</param>
        /// <returns>格式化后的字节流</returns>
        byte[] Format(params object[] message);

        /// <summary>
        ///     把仪器返回的内容填充到输出结构中
        /// </summary>
        /// <param name="messageBytes">返回数据的字节流</param>
        /// <param name="pos">转换标记位</param>
        /// <returns>结构化的输出数据</returns>
        IOutputStruct Unformat(byte[] messageBytes, ref int pos);
    }
}