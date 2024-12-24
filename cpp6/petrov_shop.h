#pragma once
				
#include "pch.h"
#include "petrov_item.h"
#include "petrov_used_item.h"

using namespace std;

class shop {
	vector<shared_ptr<item>> items;
public:
	void shop_read(const string& filename);
	void shop_write(const string& filename);

	void shop_delete(int id);
	void shop_add(shared_ptr<item> item);

	void clear();

	int get_size() const;

	shared_ptr<item> get(int i);
};