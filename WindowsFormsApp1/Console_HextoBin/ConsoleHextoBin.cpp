// ConsoleHextoBin.cpp : Defines the entry point for the console application.
//

#include "stdafx.h"

#include "hexlexer.h"
#include <iostream>
using namespace std;
//获取记录标识
char Hex::GetRecordMark()
{
	return this->m_cRecordMark;
}
//获取每条记录的长度
size_t Hex::GetRecordLength()
{
	//char *len = (char*)malloc(sizeof(char)* 3);
	if (strlen(m_cBuffer) >= 2)
	{
		char len[3];
		len[0] = m_cBuffer[0];
		len[1] = m_cBuffer[1];
		len[2] = '\0';
		char *p = NULL;
		return strtol(len, &p, 16);
	}
	else
	{
		return 0;
	}
}
//获取装载偏移
char* Hex::GetLoadOffset()
{
	if (strlen(m_cBuffer) == (GetRecordLength() + 5) * 2)
	{
		char *offset = (char*)malloc(sizeof(char) * 5);
		for (int i = 0; i < 4; ++i)
		{
			offset[i] = m_cBuffer[i + 2];
		}
		offset[4] = '\0';
		m_pLoadOffset = offset;
		offset = NULL;
	}
	return m_pLoadOffset;
}
//获取记录类型
char* Hex::GetRecordType()
{
	if (strlen(m_cBuffer) == (GetRecordLength() + 5) * 2)
	{
		char *type = (char*)malloc(sizeof(char) * 3);
		type[0] = m_cBuffer[6];
		type[1] = m_cBuffer[7];
		type[2] = '\0';
		m_pRecordType = type;
		type = NULL;
	}
	return m_pRecordType;
}
//获取数据
char* Hex::GetData()
{
	if (strlen(m_cBuffer) == (GetRecordLength() + 5) * 2)
	{
		int len = GetRecordLength();
		char *data = (char*)malloc(sizeof(char)*(len * 2 + 1));
		for (int i = 0; i < len * 2; ++i)
		{
			data[i] = m_cBuffer[i + 8];
		}
		data[len * 2] = '\0';
		m_pData = data;
		data = NULL;
	}
	return m_pData;
}
//获取校验和
char* Hex::GetChecksum()
{
	int len = GetRecordLength();
	if (strlen(m_cBuffer) == (len + 5) * 2)
	{
		char *checksum = (char*)malloc(sizeof(char) * 3);
		checksum[0] = m_cBuffer[(len + 5) * 2 - 2];
		checksum[1] = m_cBuffer[(len + 5) * 2 - 1];
		checksum[2] = '\0';
		m_pChecksum = checksum;
		checksum = NULL;
	}
	return m_pChecksum;
}
//解析Hex文件中的每一条记录
void Hex::ParseRecord(char ch)
{
	size_t buf_len = strlen(m_cBuffer);
	if (GetRecordMark() == ch)
	{
		m_bRecvStatus = true;
		m_cBuffer[0] = '\0';
		//m_nIndex = 0;
		return;
	}
	if ((buf_len == (GetRecordLength() + 5) * 2 - 1))
	{
		//接收最后一个字符
		m_cBuffer[buf_len] = ch;
		m_cBuffer[buf_len + 1] = '\0';
		//检验接收的数据
		char temp[3];
		char *p = NULL;
		long int checksum = 0;
		for (int i = 0; i < strlen(m_cBuffer); i += 2)
		{
			temp[0] = m_cBuffer[i];
			temp[1] = m_cBuffer[i + 1];
			temp[2] = '\0';
			checksum += strtol(temp, &p, 16);
			temp[0] = '\0';
		}
		checksum &= 0x00ff;//取计算结果的低8位
		if (checksum == 0)//checksum为0说明接收的数据无误
		{
			cout << "RecordMark " << GetRecordMark() << endl;
			cout << "RecordLength " << GetRecordLength() << endl;
			cout << "LoadOffset " << GetLoadOffset() << endl;
			cout << "RecordType " << GetRecordType() << endl;
			cout << "Data " << GetData() << endl;
			cout << "Checksum " << GetChecksum() << endl;
		}
		else//否则接收数据有误
		{
			cout << "Error!" << endl;
		}
		m_cBuffer[0] = '\0';
		m_bRecvStatus = false;
		m_nRecordLength = 0;
		m_pLoadOffset = NULL;
		m_pRecordType = NULL;
		m_pChecksum = NULL;
		m_bRecvStatus = false;
	}
	else if (m_bRecvStatus)
	{
		m_cBuffer[buf_len] = ch;
		m_cBuffer[buf_len + 1] = '\0';
		//m_nIndex++;
	}
}
//解析Hex文件
void Hex::ParseHex(char *data)
{
	for (int i = 0; i < strlen(data); ++i)
	{
		ParseRecord(data[i]);
	}
}
int main(int argc, char *argv[])
{
	freopen("in.txt", "r", stdin);
	freopen("out.txt", "w", stdout);

	Hex hex(':');
	char ch;
	
	while (cin>>ch)
	{
		hex.ParseRecord(ch);
		//if (ch == '\0')
		//{
		//	cout<<endl;
		//}
		//cout<<ch<<" "<<int(ch)<<endl;
	}
	fclose(stdout);
	fclose(stdin);
	return 0;
}
