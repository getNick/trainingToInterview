// binariTree.cpp: определяет точку входа для консольного приложения.
//
#include "stdafx.h"
#include <iostream>
using namespace std;



class  node
{
public:
	node(double value) {
		this->value = value;
	}
	~node() {
		delete r;
		delete l;
	}
	double getValue() {
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
	double value;
	node * r;
	node * l;
};
class binariTree
{
public:
	binariTree() {

	}
	~binariTree() {

	}
	void addNode(node * p) {
		if (!root) {
			root = p;
		}
		else
		{
			addNode(p, root);
		}
	}
	void addNode(node* p, node * owner) {
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
	node* root=0;
};


int main()
{
	binariTree tree;
	tree.addNode(new node(8.3));
	tree.addNode(new node(4.0));
	tree.addNode(new node(13.4));
	tree.addNode(new node(5.5));
	tree.addNode(new node(5.3));
    return 0;
}

