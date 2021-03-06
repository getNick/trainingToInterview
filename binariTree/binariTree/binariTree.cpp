// binariTree.cpp: определяет точку входа для консольного приложения.
//
#include "stdafx.h"
#include <iostream>
using namespace std;


template <typename T> class  node
	{
	public:
		node(T value) {
			this->value = value;
		}
		~node() {
			delete r;
			delete l;
		}
		T getValue() {
			return value;
		}
		node * getL() {
			return l;
		}
		node * getR() {
			return r;
		}
		void setR(node *r) {
			this->r = r;
		}
		void setL(node *l) {
			this->l = l;
		}
	private:
		T value;
		node * r;
		node * l;
};

template <typename T> class binariTree
{
public:
	binariTree() {

	}
	~binariTree() {

	}
	void insert(T value) {
		node<T> * p = new node<T>(value);
		if (!root) {
			root = p;
		}
		else
		{
			addNode(p, root);
		}
	}
	void addNode(node<T>*p, node<T>*owner) {
		if (p->getValue() > owner->getValue()) {
			if (!(owner->getR())) {
				owner->setR(p);
			}
			else
			{
				addNode(p, owner->getR());
			}
		}
		else
		{
			if (!(owner->getL())) {
				owner->setL(p);
			}
			else
			{
				addNode(p, owner->getL());
			}
		}
	}
private:
	node<T>* root=0;
};


int main()
{
	binariTree<string> tree;
	tree.insert("adc");
	tree.insert("asd");
	tree.insert("dvc");
	tree.insert("dva");
	tree.insert("dba");
    return 0;
}

