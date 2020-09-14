#ifndef _HEXLEXER_H_
#define _HEXLEXER_H_
#include <cstdio>
#include <cstring>
#include <cstdlib>
/*
Intel Hex文件解析器V1.0
Hex文件的格式如下：
RecordMark	RecordLength	LoadOffset	RecordType	Data	Checksum
在Intel Hex文件中，RecordMark规定为“:”
*/
#pragma warning(disable:4996)
#define MAX_BUFFER_SIZE 43
class Hex
{
public:
	Hex(char mark);
	~Hex();
	void ParseHex(char *data);//解析Hex文件
	void ParseRecord(char ch);//解析每一条记录
	size_t GetRecordLength();//获取记录长度
	char GetRecordMark();//获取记录标识
	char *GetLoadOffset();//获取内存装载偏移
	char *GetRecordType();//获取记录类型
	char *GetData();//获取数据
	char *GetChecksum();//获取校验和

private:
	char m_cBuffer[MAX_BUFFER_SIZE];//存储待解析的记录
	char m_cRecordMark;//记录标识
	size_t m_nRecordLength;//记录长度
	char *m_pLoadOffset;//装载偏移
	char *m_pRecordType;//记录类型
	char *m_pData;//数据字段
	char *m_pChecksum;//校验和
	bool m_bRecvStatus;//接收状态标识
					   //size_t m_nIndex;//缓存的字符索引值
};

Hex::Hex(char mark)
{
	this->m_cRecordMark = mark;
	m_cBuffer[0] = '\0';
	//m_pBuffer = NULL;
	m_nRecordLength = 0;
	m_pLoadOffset = NULL;
	m_pRecordType = NULL;
	m_pData = NULL;
	m_pChecksum = NULL;
	m_bRecvStatus = false;
	//m_nIndex = 0;
}

Hex::~Hex()
{
	delete m_pLoadOffset, m_pRecordType, m_pData, m_pChecksum;
}

#endif#pragma once
